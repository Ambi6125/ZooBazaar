using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.People
{
    public class Employee
    {
        private readonly int? _id;
        private string name;
        private string address;
        private string phoneNumber;
        private List<Contract> contracts; //HACK: contracts here should be stored in order


        /// <summary>
        /// NEW employee
        /// </summary>
        public Employee(string name, string address, string phone, Contract c)
        {
            this.name = name;
            this.address = address;
            phoneNumber = phone;
            contracts = new List<Contract>();
            contracts.Add(c);
        }

        /// <summary>
        /// EXISTING employee
        /// </summary>
        public Employee()
        {
            throw new NotImplementedException();
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
