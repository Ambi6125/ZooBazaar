using EasyTools.RegexTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAccount;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarLogicLayer.Managers
{
    public class AccountManager
    {
        private readonly IDalAccount _dataSource;

        private AccountManager(IDalAccount dataSource)
        {
            _dataSource = dataSource;
        }

        public static AccountManager CreateForDatabase()
        {
            return new AccountManager(new DBAccount());
        }

        public IValidationResponse AddAccount(Account account)
        {
            return _dataSource.AddAccount(account);
        }

        public IReadOnlyList<Account> GetByUsername(string username)
        {
            List<Account> accounts = new List<Account>();
            var result = _dataSource.GetByUsername(username);
            foreach (var accountData in result)
            {
                int id = accountData.GetValueAs<int>("id");
                string dbusername = accountData.GetValueAs<string>("username");
                string email = accountData.GetValueAs<string>("email");
                string salt = accountData.GetValueAs<string>("salt");
                string password = accountData.GetValueAs<string>("hashedPassword");
                AccountType type = accountData.GetValueAs<AccountType>("accountType");

                Account a = new Account(id, dbusername, salt, password, email, type);
                accounts.Add(a);
            }
            return accounts;
        }

        public Account? GetByUsernameExact(string username)
        {
            var resultset = GetByUsername(username);
            Account? exactMatch = resultset.FirstOrDefault(a => a.Username.ToLower() == username.ToLower());
            return exactMatch;
        }

        public IValidationResponse UpdateAccount(Account a)
        {
            return _dataSource.UpdateAccount(a);
        }

        /// <summary>
        /// Gets an account by its email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when input is not an email address.</exception>
        public Account? GetByEmail(string email)
        {
            if (!RegexToolBox.IsEmail(email))
            {
                throw new ArgumentException("Not an email address");
            }

            var result = _dataSource.GetByEmail(email);
            if (!result.Any())
            {
                return null;
            }

            var accountData = result.First();

            int id = accountData.GetValueAs<int>("id");
            string dbusername = accountData.GetValueAs<string>("username");
            string dbemail = accountData.GetValueAs<string>("email");
            string salt = accountData.GetValueAs<string>("salt");
            string password = accountData.GetValueAs<string>("hashedPassword");
            AccountType type = accountData.GetValueAs<AccountType>("accountType");

            Account a = new Account(id, dbusername, salt, password, dbemail, type);
            return a;
        }

        public IReadOnlyCollection<Account> GetAll()
        {
            return GetByUsername(string.Empty);
        }

        public bool UsernameIsTaken(string username)
        {
            return GetByUsername(username).Any(a => a.Username.ToLower().Equals(username.ToLower()));
        }

        public IValidationResponse DeleteAccount(Account newAccount)
        {
            return _dataSource.DeleteAccount(newAccount);
        }
    }
}
