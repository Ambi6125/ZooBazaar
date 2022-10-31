using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;

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

        public IValidationResponse UpdateEntry(IDataProvider employee)
        {
            object idValue = employee.GetParameterArgs().ElementAt(0);
            MySqlCondition condition = new MySqlCondition("id", idValue, Strictness.MustMatchExactly);
            UpdateQuery query = new UpdateQuery(table,  employee, condition);

            return communicator.Update(query);
        }
    }
}
