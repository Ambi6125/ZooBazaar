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
                int id = contractData.GetValueAs<int>("id");
                string resultname = contractData.GetValueAs<string>("employeeName");
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

                Contract c = new Contract(id, startDate, endDate, type, resultname);
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
                int id = contractData.GetValueAs<int>("id");
                string name = contractData.GetValueAs<string>("employeeName");
                DateTime startDate = contractData.GetValueAs<DateTime>("startDate");
                DateTime endDate = contractData.GetValueAs<DateTime>("endDate");
                int hours = contractData.GetValueAs<int>("contractHours");
                ContractType type = (ContractType)hours;

                Contract c = new Contract(id, startDate, endDate, type, name);
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
                int id = contractData.GetValueAs<int>("id");
                string name = contractData.GetValueAs<string>("employeeName");
                DateTime startDate = contractData.GetValueAs<DateTime>("startDate");
                DateTime endDate = contractData.GetValueAs<DateTime>("endDate");
                int hours = contractData.GetValueAs<int>("contractHours");
                ContractType type = (ContractType)hours;

                Contract c = new Contract(id, startDate, endDate, type,  name);
                contracts.Add(c);
            }
            return contracts;
        }
    }
}
