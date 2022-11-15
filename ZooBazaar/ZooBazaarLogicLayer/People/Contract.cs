using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.People
{
    public enum ContractType { ZeroBased = 0, PartTime = 32, FullTime = 40 }

    public class Contract : IDataProvider
    {
        private readonly int? id;
        private DateTime startDate;
        private DateTime? endDate;

        public ContractType ContractType { get; private set; }
        public bool IsActive { get; set; }
        public DateTime StartDate => startDate;
        public DateTime? EndDate => endDate;

        public string EmployeeName { get; }

        public int ID => id.Value;

        public Contract(DateTime startDate, DateTime? endDate, ContractType contractType, bool isActive)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            ContractType = contractType;
            IsActive = isActive;
        }

        public Contract(int? id, DateTime startDate, DateTime? endDate, ContractType contractType, bool isActive, string name)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            ContractType = contractType;
            IsActive = isActive;
            EmployeeName = name;
        }

        public Contract(int? id, DateTime startDate, DateTime? endDate, ContractType contractType, bool isActive)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            ContractType = contractType;
            IsActive = isActive;
        }

        public void ChangeType(ContractType type)
        {
            ContractType = type;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            ParameterValueCollection pvc = new ParameterValueCollection();
            pvc.Add("id", id);
            pvc.Add("startDate", startDate);
            pvc.Add("endDate", endDate);
            pvc.Add("isActive", IsActive);
            pvc.Add("contractHours", (int)ContractType);

            return pvc;
        }
    }
}
