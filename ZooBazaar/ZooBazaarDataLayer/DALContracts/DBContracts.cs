using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALContracts
{
    public class DBContracts : IDALContacts
    {
        private readonly IDatabaseCommunicator _communicator = new MySqlCommunicator(Data.connectionString);
        private readonly MySqlTable zb_contracts = new MySqlTable("zb_contracts");
        public IValidationResponse CreateContract(IDataProvider contract)
        {
            InsertQuery q = new InsertQuery(zb_contracts, contract);

            return _communicator.Insert(q);
        }

        public IValidationResponse UpdateContract(IDataProvider contract)
        {
            int accountId = contract.GetParameterArgs().GetValueAs<int>("id");
            MySqlCondition condition = new MySqlCondition("id", accountId, Strictness.MustMatchExactly);
            UpdateQuery q = new UpdateQuery(zb_contracts, contract, condition);

            return _communicator.Update(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmployeeName(string name)
        {
            MySqlTable join = zb_contracts.Join(Join.Inner, "zb_employees", "zb_employees.id = zb_contracts.employeeId");            
            MySqlCondition condition = new MySqlCondition("firstName", name, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(join, "*", condition);
            return _communicator.Select(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByStatus(bool active)
        {            
            MySqlCondition condition = new MySqlCondition("isActive", active, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(zb_contracts, "*", condition);
            return _communicator.Select(q);
        }
    }
}
