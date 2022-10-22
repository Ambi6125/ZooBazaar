using EasyTools.RegexTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.PasswordHandling;
using EasyTools.RegexTools;
using System.Text.RegularExpressions;
using EasyTools.MySqlDatabaseTools;

namespace ZooBazaarLogicLayer.People
{
    public enum AccountType { Default = 0, Admin = 1 }
    
    public class Account : IDataProvider
    {
        private readonly int? id;
        private readonly string salt;
        private string hashedPassword;
        private string username;
        private string email;
        

        public string Username
        {
            get => username;
            set
            {
                if (value.Length > 0)
                    username = value;
                else
                    throw new ArgumentException("Cannot be empty.");
            }
        }

        public string Email => email;

        public AccountType AccountType { get; private set; }

        /// <summary>
        /// Create new user
        /// </summary>
        public Account(string username, string password, HashAlgorithm hash, string email, AccountType accountType = AccountType.Default)
        {
            salt = Generate.NewString(60);
            hashedPassword = hash(password, salt);
            this.username = username;
            this.email = email;
            AccountType = accountType;
        }

        /// <summary>
        /// Read user data
        /// </summary>
        public Account(int? id, string username, string salt, string password, string email, AccountType accountType)
        {
            this.id = id;
            this.salt = salt;
            hashedPassword = password;
            this.username = username;
            this.email = email;
            AccountType = accountType;
        }


        /// <summary>
        /// Checks whether the input password, when hashed, matches the one saved in the database.
        /// Run this before logging in!
        /// </summary>
        /// <returns>True if it matches, otherwise false.</returns>
        public bool PasswordIsCorrect(string password, HashAlgorithm hash)
        {
            return hashedPassword == hash(password, salt);
        }

        public bool ChangeMail(string mailAddress)
        {
            
            if (RegexToolBox.IsEmail(mailAddress))
            {
                email = mailAddress;
                return true;
            }
            return false;
        }

        public void ChangeType(AccountType type)
        {
            AccountType = type;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            ParameterValueCollection pvc = new ParameterValueCollection();
            pvc.Add("id", id);
            pvc.Add("username", username);
            pvc.Add("email", email);
            pvc.Add("salt", salt);
            pvc.Add("hashedPassword", hashedPassword);
            pvc.Add("accountType", AccountType);

            return pvc;
        }
    }
}
