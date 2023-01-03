using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Exceptions;

namespace ZooBazaarLogicLayer.People
{
    public class Employee : IDataProvider, IEquatable<Employee>
    {
        private readonly int? _id;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private DateTime birthDate;
        private int? accountId;

        public int? ID => _id;
        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 0)
                    name = value;
                else
                    throw new ArgumentException("Cannot be empty.");
            }
        }
        public string Address => address;
        public string PhoneNumber => phoneNumber;
        public string Email => email;
        

        public string BirthDay => birthDate.ToString("dd/MM/yyyy");
        public int Age => (int)Math.Floor((DateTime.Today - birthDate.Date).Days / 365.25);

        public Employee()
        {

        }

        /// <summary>
        /// NEW employee
        /// </summary>
        public Employee(string name, string address, string phone,string email, DateTime birthDate)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phone;
            this.email = email;
            this.birthDate = birthDate;
        }

        /// <summary>
        /// EXISTING employee
        /// </summary>
        public Employee(int? id,string name, string address, string phone, string email, DateTime birthDate/*, List<Contract> contracts*/)
            :this(name,address,phone,email, birthDate)
        {
            this._id = id;
            //this.contracts = contracts;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            IParameterValueCollection args = new ParameterValueCollection();
            args.Add("id", _id);
            args.Add("employeeName", name);
            args.Add("address", address);
            args.Add("phoneNumber", phoneNumber);
            args.Add("email", email);
            args.Add("birthDate", birthDate);
            args.Add("accountId", accountId);

            return args;
        }
        /// <summary>
        /// Returns the currently active contract, if there is one.
        /// </summary>
        public Contract? CurrentContract
        {
            get
            {
                Contract t = contracts.LastOrDefault();
                if (t is null || t.IsActive == false)
                {
                    return null;
                }
                else
                {
                    return t;
                }
            }
        }

        public void ChangeAddress(string a)
        {
            address = a;
        }
        public void ChangePhoneNumber(string p)
        {
            
            phoneNumber = p;
        }
        public void ChangeEmail(string e)
        {
            
            email = e;
        }
        
        public bool AssignAccount(Account account)
        {
            bool isNotAssigned = !accountId.HasValue;
            if (isNotAssigned)
            {
                this.accountId = account.ID;
            }
            return isNotAssigned;
        }

        public void ChangeBirthDay(DateTime t)
        {
            if (DateTime.Today < t)
            {
                throw new ArgumentException("Impossible birthday.");
            }
            birthDate = t;
        }
        

        public override string ToString()
        {
            return Name;
        }

        public bool Equals(Employee? other)
        {
            return ID.Equals(other?.ID);
        }
    }
}
