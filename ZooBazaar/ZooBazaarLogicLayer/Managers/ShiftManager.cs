using EasyTools.Validation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALScheduling;
using ZooBazaarDataLayer.DALScheduling.DALShift;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarLogicLayer.Managers
{
    public class ShiftManager
    {
        private readonly IDalShift dataSource;


        private ICollection<Employee> BuildEmployees(int id)
        {
            var tableWithCertainId = dataSource.GetEmployeesFromShift(id);
            var shiftEmployees = new List<Employee>();
            foreach (var item in tableWithCertainId) //Makes employees for enclosing shift
            {
                int empId = item.GetValueAs<int>("zb_employees.id");
                string name = item.GetValueAs<string>("employeeName");
                string address = item.GetValueAs<string>("address");
                string phoneNumber = item.GetValueAs<string>("phoneNumber");
                string email = item.GetValueAs<string>("email");
                DateTime birthdate = Convert.ToDateTime(item.GetValueAs<string>("birthDate"));

                Employee emp = new Employee(empId, name, address, phoneNumber, email, birthdate);
                shiftEmployees.Add(emp);
            }
            return shiftEmployees;
        }

        private ShiftManager(IDalShift dal)
        {
            dataSource = dal;
        }

        public IReadOnlyCollection<Shift> GetByDate(DateTime date)
        {
            List<Shift> shifts = new List<Shift>();
            var allData = dataSource.GetByDate(date);

            var identifiers = dataSource.GetIdsOnDate(date);

            foreach (int id in identifiers) //Makes shift
            {

                var tableWithCertainId = allData.Where(x => x.GetValueAs<int>("zb_shifts.id") == id);

                List<Employee> shiftEmployees = BuildEmployees(id).ToList();


                var singleEntry = tableWithCertainId.First();

                int shiftId = singleEntry.GetValueAs<int>("zb_shifts.id");
                ShiftType type = singleEntry.GetValueAs<ShiftType>("shiftType");
                DateTime shiftDate = Convert.ToDateTime(singleEntry.GetValueAs<string>("date"));

                Shift s = new Shift(shiftId, shiftDate, shiftEmployees, type);
                shifts.Add(s);
            }

            return shifts;
        }

        public int GetRecentId()
        {
            return dataSource.GetMostRecentId();
        }
        
        public Shift? GetByDateAndType(DateTime date, ShiftType type)
        {
            var response = dataSource.GetByTime(date, (int)type);

            var singleResult = response.FirstOrDefault();

            if(singleResult == null)
                return null;

            int id = singleResult.GetValueAs<int>("id");
            ShiftType shiftType = (ShiftType)singleResult.GetValueAs<int>("shiftType");
            var employees = BuildEmployees(id);
            DateTime responseDate = Convert.ToDateTime(singleResult.GetValueAs<string>("date"));

            Shift result = new Shift(id, responseDate, employees, shiftType);
            return result;
        }

        public static ShiftManager CreateForDatabase()
        {
            return new ShiftManager(new DBShifts());
        }

        public IValidationResponse AddShift(Shift s)
        {
            return dataSource.Add(s);
        }

        public IValidationResponse Register(ShiftEmployeeRelationShip data)
        {
            return dataSource.RegisterEmployee(data);
        }

        public IValidationResponse Register(Shift shift, Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee.ID);

            var relationship = new ShiftEmployeeRelationShip(employee.ID.Value, shift.ID);
            return Register(relationship);
        }

        public IValidationResponse RemoveEmployee(Shift shift, Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee.ID);
            return RemoveEmployee(new ShiftEmployeeRelationShip(employee.ID.Value, shift.ID));
        }

        public IValidationResponse RemoveEmployee(ShiftEmployeeRelationShip relationShip)
        {
            return dataSource.RemoveEmployee(relationShip);
        }
    }
}
