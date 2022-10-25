using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZooBazaarDataLayer.DALAccount;
using ZooBazaarDataLayer.DALContracts;
using ZooBazaarLogicLayer.People;

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
                DateTime startDate = contractData.GetValueAs<DateTime>("startDate");
                DateTime endDate = contractData.GetValueAs<DateTime>("endDate");
                bool isActive = contractData.GetValueAs<bool>("isActive");
                int hours = contractData.GetValueAs<int>("contarctHours");
                ContractType type = (ContractType)hours;

                Contract c = new Contract(id, startDate, endDate, type, isActive);
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
                DateTime startDate = contractData.GetValueAs<DateTime>("startDate");
                DateTime endDate = contractData.GetValueAs<DateTime>("endDate");
                bool isActive = contractData.GetValueAs<bool>("isActive");
                int hours = contractData.GetValueAs<int>("contarctHours");
                ContractType type = (ContractType)hours;

                Contract c = new Contract(id, startDate, endDate, type, isActive);
                contracts.Add(c);
            }
            return contracts;
        }
    }
}
