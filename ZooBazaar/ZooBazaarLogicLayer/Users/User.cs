using EasyTools.RegexTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.PasswordHandling;

namespace ZooBazaarLogicLayer.Users
{
    //TODO: Extend this class after client meeting.
    public abstract class User
    {
        private readonly int? id;
        private readonly string salt;
        private string hashedPassword;
        private string username;

        public string Username
        {
            get => username;
            set
            {
                if(value.Length > 0)
                    username = value;
            }
        }

        public string Email { get; private set; }

        /// <summary>
        /// Create new user
        /// </summary>
        public User(string username, string password, HashAlgorithm hash)
        {
            salt = Generate.NewString(69);
            hashedPassword = hash(password, salt);
            this.username = username;
        }

        /// <summary>
        /// Read user data
        /// </summary>
        public User(int? id, string username, string salt, string password)
        {
            this.id = id;
            this.salt = salt;
            hashedPassword = password;
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
                Email = mailAddress;
                return true;
            }
            return false;
        }
    }
}
