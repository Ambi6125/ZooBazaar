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

        public static AvailabilityManager CreateForDatabase()
        {
            return new AvailabilityManager(new DBAvailability());
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

        public IReadOnlyCollection<UnavailabilityData> GetByMoment(DayOfWeek weekday, ShiftType momentOfDay)
        {
            var response = repo.GetByDayAndType(weekday, (int)momentOfDay);
            List<UnavailabilityData> data = new List<UnavailabilityData>();
            foreach (var parameters in response)
            {
                int id = parameters.GetValueAs<int>("id");
                string empName = parameters.GetValueAs<string>("name");
                string address = parameters.GetValueAs<string>("address");
                string phoneNumber = parameters.GetValueAs<string>("phoneNumber");
                string email = parameters.GetValueAs<string>("email");
                DateTime birthDate = parameters.GetValueAs<DateTime>("birthDate");
                int accountId = parameters.GetValueAs<int>("accountId");

                Employee emp = new Employee(id, empName, address, phoneNumber, email, birthDate);
                data.Add(new UnavailabilityData(emp, weekday, momentOfDay));
            }
            return data;
        }

        public IReadOnlyCollection<UnavailabilityData> GetAllData()
        {
            List<UnavailabilityData> result = new List<UnavailabilityData>();
            var repoResponse = repo.GetAllData();
            foreach (var item in repoResponse)
            {
                int id = item.GetValueAs<int>("employeeId");
                var dayOfWeek = Enum.Parse(typeof(DayOfWeek), item.GetValueAs<string>("day"), true);
                var shiftType = item.GetValueAs<ShiftType>("shiftType");
                string empName = item.GetValueAs<string>("name");
                string address = item.GetValueAs<string>("address");
                string phoneNumber = item.GetValueAs<string>("phoneNumber");
                string email = item.GetValueAs<string>("email");
                DateTime birthDate = item.GetValueAs<DateTime>("birthDate");
                int accountId = item.GetValueAs<int>("accountId");

                Employee emp = new Employee(id, empName, address, phoneNumber, email, birthDate);

                result.Add(new UnavailabilityData(emp, (DayOfWeek)dayOfWeek, shiftType));
            }
            return result;
        }
    }
}
