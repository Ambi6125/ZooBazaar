using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZooBazaarLogicLayer.Animals;

namespace ZooBazaarLogicLayer.People
{
    public class Employee
    {
        private readonly int? _id;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private DateTime birthDate;
        //TODO: Implement Contracts for Employees
        private List<Contract> contracts; //HACK: contracts here should be stored in order

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

        public string BirthDay => birthDate.ToString("dd/MM/yyyy");
        public int Age => (int)Math.Floor((DateTime.Today - birthDate.Date).Days / 365.25);

        /// <summary>
        /// NEW employee
        /// </summary>
        public Employee(string name, string address, string phone,string email, DateTime birthDate/*, Contract c*/)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phone;
            this.email = email;
            this.birthDate = birthDate;
            //contracts = new List<Contract>();
            //contracts.Add(c);
        }

        /// <summary>
        /// EXISTING employee
        /// </summary>
        public Employee(int? id,string name, string address, string phone, string email, DateTime birthDate/*, Contract c*/)
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

        
        public bool IsActive
        {
            get
            {
                //Should check whether the current contract is active.
                throw new NotImplementedException();
            }
        }
    }
}
