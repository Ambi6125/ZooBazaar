using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALScheduling.DALAvailability;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Availability;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarLogicLayer.Managers
{
    public class AvailabilityManager
    {
        private readonly IDALAvailability repo;

        public AvailabilityManager(IDALAvailability repo)
        {
            this.repo = repo;
        }

        public IValidationResponse MarkUnavailable(UnavailabilityData data)
        {
            return repo.Insert(data);
        }

        public IValidationResponse MarkAvailable(UnavailabilityData data)
        {
            return repo.Remove(data);
        }

        public IReadOnlyCollection<UnavailabilityData> GetByDay(DayOfWeek day)
        {
            var empManager = EmployeeManager.CreateForDatabase();
            List<UnavailabilityData> result = new List<UnavailabilityData>();
            //DB Calling code;

            var repoResponse = repo.GetByDay(day);

            foreach(var item in repoResponse)
            {
                var employee = empManager.GetEmployeesById(item.GetValueAs<int>("employeeId")).Single();
                var dayOfWeek = Enum.Parse(typeof(DayOfWeek), item.GetValueAs<string>("day"), true);
                var shiftType = item.GetValueAs<ShiftType>("shiftType");

                result.Add(new UnavailabilityData(employee, day, shiftType));
            }

            return result;
        }
    }
}
