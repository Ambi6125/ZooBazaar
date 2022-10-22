using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALAccount
{
    public class DBAccount : IDalAccount
    {
        private readonly MySqlTable zb_accounts = new MySqlTable("zb_accounts");
        private readonly IDatabaseCommunicator _communicator = new MySqlCommunicator(Data.connectionString);
        public IValidationResponse AddAccount(IDataProvider account)
        {
            InsertQuery q = new InsertQuery(zb_accounts, account);
            
            return _communicator.Insert(q);
        }

        public IValidationResponse DeleteAccount(IDataProvider account)
        {
            DeleteQuery q = new DeleteQuery(zb_accounts, "id", account);

            return _communicator.Delete(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmail(string email)
        {
            MySqlCondition condition = new MySqlCondition("email", email, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(zb_accounts, "*", condition);
            return _communicator.Select(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByUsername(string username)
        {
            MySqlCondition condition = new MySqlCondition("username", "%" + username + "%", Strictness.MustBeSimilar);
            SelectQuery q = new SelectQuery(zb_accounts, "*", condition);

            return _communicator.Select(q);
        }

        public IValidationResponse UpdateAccount(IDataProvider account)
        {
            int accountId = account.GetParameterArgs().GetValueAs<int>("id");
            MySqlCondition condition = new MySqlCondition("id", accountId, Strictness.MustMatchExactly);
            UpdateQuery q = new UpdateQuery(zb_accounts, account, condition);

            return _communicator.Update(q); 
        }
    }
}
