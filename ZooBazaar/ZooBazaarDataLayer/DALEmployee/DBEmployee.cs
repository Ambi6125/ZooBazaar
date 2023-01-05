using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.Validation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZooBazaarDataLayer.DALAnimal;
using ZooBazaarDataLayer.DALContracts;

namespace ZooBazaarDataLayer.DALEmployee
{
    public class DBEmployee : IDALEmployee
    {
        private IDatabaseCommunicator communicator = new MySqlCommunicator(Data.connectionString);

        private readonly MySqlTable table = new MySqlTable("zb_employees");
        public IValidationResponse AddEntry(IDataProvider employee)
        {
            InsertQuery query = new InsertQuery(table, employee);

            return communicator.Insert(query);
        }

        public IValidationResponse DeleteEntry(IDataProvider employee)
        {
            object idValue = employee.GetParameterArgs().ElementAt(0);
            MySqlCondition condition = new MySqlCondition("id", idValue, Strictness.MustMatchExactly);
            UpdateQuery query = new UpdateQuery(table, employee, condition);

            return communicator.Update(query);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name)
        {
            MySqlCondition condition = new MySqlCondition("employeeName", "%" + name + "%", Strictness.MustBeSimilar);
            SelectQuery query = new SelectQuery(table, "*", condition);

            return communicator.Select(query);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetById(int id)
        {
            MySqlCondition condition = new MySqlCondition("accountId", "%" + id + "%", Strictness.MustBeSimilar);
            SelectQuery query = new SelectQuery(table, "*", condition);

            return communicator.Select(query);
        }

        public IValidationResponse UpdateEntry(IDataProvider employee)
        {
            object idValue = employee.GetParameterArgs().ElementAt(0);
            MySqlCondition condition = new MySqlCondition("id", idValue, Strictness.MustMatchExactly);
            UpdateQuery query = new UpdateQuery(table,  employee, condition);

            return communicator.Update(query);
        }

        //TODO: Make it with left join, result need to give employees without contracts
        public MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi468695;Database=dbi468695;Pwd=MorbinTime;SslMode=none;");
            return conn;
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesWithNoContracts()
        {
            //MySqlTable join = table.Join(Join.Left, "zb_employeecontracts", "zb_employees.id = zb_employeecontracts.employeeId");
            //MySqlCondition condition = new MySqlCondition("zb_employeecontracts.contractId", null, Strictness.MustMatchExactly);
            //SelectQuery q = new SelectQuery(join, "zb_employees.*", condition);
            List<ParameterValueCollection> list = new List<ParameterValueCollection>();
            string command = "SELECT * FROM zb_employees LEFT JOIN zb_contracts ON zb_contracts.employeeId = zb_employees.id WHERE zb_contracts.id IS NULL";
            MySqlConnection conn = GetConnection();
            MySqlCommand read = new MySqlCommand(command, conn);
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
            //TODO: work on proper exhceptions
            catch(MySqlException)
            {
                return null;
            }
            finally
            {
                if (conn.State != 0)
                {
                    conn.Close();
                }
            }
            return list;
        }

        //public IValidationResponse UpdateContractStatus(IDataProvider employee)
        //{
        //    object idValue = employee.GetParameterArgs().ElementAt(0);
        //    MySqlCondition condition = new MySqlCondition("id", idValue, Strictness.MustMatchExactly);
        //    UpdateQuery query = new UpdateQuery(table, employee, condition);

        //    return communicator.Update(query);
        //}

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesWithInactiveContracts(bool isActive)
        {
           
            MySqlTable join = table.Join(Join.Inner, "zb_employeecontracts", "zb_employees.id = zb_employeecontracts.employeeId");
            MySqlTable join2 = join.Join(Join.Inner, "zb_contracts","zb_employeecontracts.contractId = zb_contracts.id");
            MySqlCondition condition = new MySqlCondition("isActive", isActive, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(join2, "zb_employees.*", condition);
            return communicator.Select(q);
        }

        //TODO: Change
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAllEmployeesContracts(int? id)
        {
            MySqlTable jointable = new MySqlTable("zb_contracts");
            MySqlTable join = jointable.Join(Join.Inner, "zb_employeecontracts", "zb_contracts.id = zb_employeecontracts.contractId");
            MySqlCondition condition = new MySqlCondition("employeeId", id, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(join, "zb_contracts.*, zb_employees.*",condition);
            return communicator.Select(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAllEmployees()
        {
            
            SelectQuery query = new SelectQuery(table, "*");

            return communicator.Select(query);
        }

        public IValidationResponse UpdateContractStatus(IDataProvider employee)
        {
            throw new NotImplementedException();
        }
    }
}
