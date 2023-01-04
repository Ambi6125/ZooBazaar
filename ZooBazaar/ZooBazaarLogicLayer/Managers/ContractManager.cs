using EasyTools.MySqlDatabaseTools;
using EasyTools.ObjectManagingTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZooBazaarDataLayer.DALAccount;
using ZooBazaarDataLayer.DALContracts;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Zones;
using Contract = ZooBazaarLogicLayer.People.Contract;

namespace ZooBazaarLogicLayer.Managers
{
    public class ContractManager
    {
        private readonly IDALContacts _dataSource;

        private ContractManager(IDALContacts dataSource)
        {
            _dataSource = dataSource;
        }

        public static ContractManager CreateForDatabase()
        {
            return new ContractManager(new DBContracts());
        }

        public IValidationResponse CreateContract(Contract contract)
        {
            return _dataSource.CreateContract(contract);
        }

        public IValidationResponse AssignContract(Employee emp)
        {
            return _dataSource.AssignContract(emp);
        }

        public IValidationResponse UpdateContract(Contract contract)
        {
            return _dataSource.UpdateContract(contract);
        }

        public IReadOnlyCollection<Contract> GetAll()
        {
            return GetByEmployeeName(string.Empty);
        }

        public IReadOnlyCollection<Contract> GetByEmployeeName(string name)
        {
            List<Contract> contracts = new List<Contract>();
            var result = _dataSource.GetByEmployeeName(name);
            foreach (var contractData in result)
            {
                int id = contractData.GetValueAs<int>(0);                
                DateTime startDate = contractData.GetValueAs<DateTime>("startDate");
                DateTime? endDate;
                try
                {
                    endDate = contractData.GetValueAs<DateTime>("endDate");
                }
                catch (InvalidCastException)
                {
                    endDate = null;
                }
                int hours = contractData.GetValueAs<int>("contractHours");
                ContractType type = (ContractType)hours;

                int employeeid = contractData.GetValueAs<int>(5);
                string resultname = contractData.GetValueAs<string>("employeeName");
                string address = contractData.GetValueAs<string>("address");
                string phone = contractData.GetValueAs<string>("phoneNumber");
                string email = contractData.GetValueAs<string>("email");
                DateTime birthday = contractData.GetValueAs<DateTime>("birthDate");
                Employee employee = new Employee(employeeid, resultname, address, phone, email, birthday);

                Contract c = new Contract(id, startDate, endDate, type, employee);
                contracts.Add(c);
            }
            return contracts;
        }

        public IReadOnlyCollection<Contract> GetByStatus(bool active)
        {
            List<Contract> contracts = new List<Contract>();
            var result = _dataSource.GetByStatus(active);
            foreach (var contractData in result)
            {
                int id = contractData.GetValueAs<int>(0);
                DateTime startDate = contractData.GetValueAs<DateTime>("startDate");
                DateTime endDate = contractData.GetValueAs<DateTime>("endDate");
                int hours = contractData.GetValueAs<int>("contractHours");
                ContractType type = (ContractType)hours;

                int employeeid = contractData.GetValueAs<int>(5);
                string resultname = contractData.GetValueAs<string>("employeeName");
                string address = contractData.GetValueAs<string>("address");
                string phone = contractData.GetValueAs<string>("phoneNumber");
                string email = contractData.GetValueAs<string>("email");
                DateTime birthday = contractData.GetValueAs<DateTime>("birthDate");
                Employee employee = new Employee(employeeid, resultname, address, phone, email, birthday);


                Contract c = new Contract(id, startDate, endDate, type, employee);
                contracts.Add(c);
            }
            return contracts;            
        }

        public IReadOnlyCollection<Contract> GetByType(int hour)
        {
            List<Contract> contracts = new List<Contract>();
            var result = _dataSource.GetByType(hour);
            foreach (var contractData in result)
            {
                int id = contractData.GetValueAs<int>(0);
                DateTime startDate = contractData.GetValueAs<DateTime>("startDate");
                DateTime endDate = contractData.GetValueAs<DateTime>("endDate");
                int hours = contractData.GetValueAs<int>("contractHours");
                ContractType type = (ContractType)hours;

                int employeeid = contractData.GetValueAs<int>(5);
                string resultname = contractData.GetValueAs<string>("employeeName");
                string address = contractData.GetValueAs<string>("address");
                string phone = contractData.GetValueAs<string>("phoneNumber");
                string email = contractData.GetValueAs<string>("email");
                DateTime birthday = contractData.GetValueAs<DateTime>("birthDate");
                Employee employee = new Employee(employeeid, resultname, address, phone, email, birthday);

                Contract c = new Contract(id, startDate, endDate, type, employee);
                contracts.Add(c);
            }
            return contracts;
        }
    }
}
