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
    public class Employee : IDataProvider
    {
        private readonly int? _id;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private DateTime birthDate;
        //TODO: Implement Contracts for Employees
        private List<Contract> contracts; //HACK: contracts here should be stored in order
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
        public Employee()
        {
           
        }

        /// <summary>
        /// EXISTING employee
        /// </summary>
        public Employee(int? id,string name, string address, string phone, string email, DateTime birthDate)
            :this(name,address,phone,email, birthDate)
        {
            this._id = id;
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

            return args;
        }
        /// <summary>
        /// Returns the currently active contract, if there is one.
        /// </summary>
        public Contract? CurrentContract => contracts.Last().IsActive ? contracts.Last() : null;

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
        
        public void ChangeBirthDay(DateTime t)
        {
            if (DateTime.Today < t)
            {
                throw new ArgumentException("Impossible birthday.");
            }
            birthDate = t;
        }
        public bool IsActive
        {
            get
            {
                if (contracts.Any())
                {
                    return CurrentContract.IsActive;
                }
                else
                {
                    throw new NoContractsException();
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
