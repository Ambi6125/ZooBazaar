using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.Validation;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ZooBazaarDataLayer.DALContracts
{
    public class DBContracts : IDALContacts
    {
        private readonly IDatabaseCommunicator _communicator = new MySqlCommunicator(Data.connectionString);
        private readonly MySqlTable zb_contracts = new MySqlTable("zb_contracts");
        private readonly MySqlTable zb_employeecontracts = new MySqlTable("zb_employeecontracts");
        public IValidationResponse CreateContract(IDataProvider contract)
        {
            InsertQuery q = new InsertQuery(zb_contracts, contract);
            return _communicator.Insert(q);
        }

        //TODO: Needs to be removed
        public IValidationResponse AssignContract(IDataProvider employee)
        {
            int recentid = LatestContractEntry();
            if(recentid != -1)
            {
                EmployeeContractLink link = new EmployeeContractLink(recentid, employee.GetParameterArgs().GetValueAs<int>("id"));
                InsertQuery q = new InsertQuery(zb_employeecontracts, link);
                return _communicator.Insert(q);
            }
            else
            {
                throw new ArgumentException("this id doesnt exist");
            }
            
        }

        public IValidationResponse UpdateContract(IDataProvider contract)
        {
            int contractId = contract.GetParameterArgs().GetValueAs<int>("id");
            MySqlCondition condition = new MySqlCondition("id", contractId, Strictness.MustMatchExactly);
            UpdateQuery q = new UpdateQuery(zb_contracts, contract, condition);

            return _communicator.Update(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmployeeName(string name)
        {
            MySqlTable join = zb_contracts.Join(Join.Inner, "zb_employees", "zb_employees.id = zb_contracts.employeeId");
            MySqlCondition condition = new MySqlCondition("employeeName", "%"+name+"%", Strictness.MustBeSimilar);
            SelectQuery q = new SelectQuery(join, "*", condition);
            return _communicator.Select(q);
        }

        //TODO: Needs to be removed
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByStatus(bool active)
        {
            MySqlTable join = zb_contracts.Join(Join.Inner, "zb_employeecontracts", "zb_employeecontracts.contractId = zb_contracts.id");
            MySqlTable join2 = join.Join(Join.Inner, "zb_employees", "zb_employees.id = zb_employeecontracts.employeeId");
            MySqlCondition condition = new MySqlCondition("isActive", active, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(join2, "zb_contracts.*, zb_employees.*", condition);
            return _communicator.Select(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByType(int hour)
        {
            MySqlTable join = zb_contracts.Join(Join.Inner, "zb_employees", "zb_employees.id = zb_contracts.employeeId");
            MySqlCondition condition = new MySqlCondition("contractHours", hour, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(join, "*", condition);
            return _communicator.Select(q);
        }

        //TODO: Need to be removed
        private int LatestContractEntry()
        {
            int id = -1;
            string q = "select * FROM zb_contracts WHERE id=(SELECT max(id) FROM zb_contracts)";
            MySqlConnection con = new MySqlConnection(Data.connectionString);
            MySqlCommand cmd = new MySqlCommand(q, con);
            using (cmd)
            {
                try
                {
                    con.Open();
                    id = (int)cmd.ExecuteScalar();                    
                }
                finally
                {
                    if(con.State != System.Data.ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
            return id;
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetActiveContracts(DateTime date)
        {
            List<ParameterValueCollection> list = new List<ParameterValueCollection>();
            string command = "select * from zb_contracts inner join zb_employees on zb_contracts.employeeId = zb_employees.id where (startDate <= @date AND coalesce(endDate, @date) >= @date) AND employeeId not in (SELECT employeeId from zb_contracts where startDate > @date);";
            using MySqlConnection conn = new MySqlConnection(Data.connectionString);
            using MySqlCommand read = new MySqlCommand(command, conn);
            read.Parameters.AddWithValue("date", date.Date);
            try
            {
                conn.Open();
                MySqlDataReader reader = read.ExecuteReader();
                while (reader.Read())
                {
                    ParameterValueCollection parameterValueCollection = new ParameterValueCollection();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ParameterValuePair paramValue = new ParameterValuePair(reader.GetName(i), reader.GetValue(i));
                        parameterValueCollection.Add(paramValue);
                    }

                    list.Add(parameterValueCollection);
                }
                reader.Close();
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return list;
        }

        //public IReadOnlyParameterValueCollection? GetLatestContractAssigned(int id)
        //{
        //    MySqlTable join = zb_contracts.Join(Join.Inner, "zb_employeecontracts", "zb_employeecontracts.contractId = zb_contracts.id");
        //    MySqlCondition condition = new MySqlCondition("employeeId", id, Strictness.MustMatchExactly);
        //    SelectQuery q = new SelectQuery(join, "zb_contracts.*, zb_employees.employeeName", condition);
        //    return _communicator.Select(q).FirstOrDefault();
        //}
    }
}
