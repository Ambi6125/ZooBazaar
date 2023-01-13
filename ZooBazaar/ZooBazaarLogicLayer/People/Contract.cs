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
        private Employee owner;

        public ContractType ContractType { get; private set; }
        public bool IsActive => (endDate is null || endDate.Value.Date > DateTime.Today) && DateTime.Today >= startDate;
        public DateTime StartDate => startDate;
        public DateTime? EndDate
        {
            get => endDate;
            set
            {
                if (value.HasValue)
                {
                    if (value.Value.Date >= DateTime.Today)
                    {
                        endDate = value;
                    }
                    else
                    {
                        throw new ArgumentException("End date cannot be in the past");
                    }
                }
                else
                {
                    endDate = null;
                }
            }
        }
        public string EmployeeName => owner.Name;
        //TODO: get contract id check if needed
        public int ID => id.Value;
        public Employee EmployeeOwner => owner;

        public Contract(DateTime startDate, DateTime? endDate, ContractType contractType, Employee owner)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            ContractType = contractType;
            this.owner = owner;
        }

        public Contract(int? id, DateTime startDate, DateTime? endDate, ContractType contractType, Employee owner)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            ContractType = contractType;
            this.owner = owner;
        }

        public void ChangeType(ContractType type)
        {
            ContractType = type;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            ParameterValueCollection pvc = new ParameterValueCollection
            {
                { "id", id },
                { "startDate", startDate },
                { "endDate", endDate },
                { "contractHours", (int)ContractType },
                { "employeeId",  owner.ID }
            };

            return pvc;
        }

        //public Contract(int? id, DateTime startDate, DateTime? endDate, ContractType contractType, string employeeName, Employee owner)
        //{
        //    this.id = id;
        //    this.startDate = startDate;
        //    this.endDate = endDate;
        //    ContractType = contractType;
        //    EmployeeName = employeeName;
        //    this.owner = owner;
        //}
    }
}
