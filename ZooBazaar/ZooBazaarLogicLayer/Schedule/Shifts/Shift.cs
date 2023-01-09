using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.People;
using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;

namespace ZooBazaarLogicLayer.Schedule.Shifts
{
    public class Shift : IDataProvider, IEquatable<Shift>
    {
        private readonly int? id;
        private readonly DateTime date;
        private ShiftType shiftType;
        private readonly List<Employee> employees;

        public int ID => id.HasValue ? id.Value : throw new NullReferenceException("No ID assigned yet.");

        public DateTime Date => date.Date;

        public IReadOnlyList<Employee> Employees => employees;
        
        public ShiftType ShiftType => shiftType;

        public Shift(DateTime date, ShiftType type)
        {
            id = null;
            this.date = date.Date;
            employees = new List<Employee>();
            shiftType = type;
        }

        public Shift(int id, DateTime dateTime, ICollection<Employee> employees, ShiftType shift)
        {
            this.id = id;
            date = dateTime.Date;
            this.employees = new List<Employee>();
            this.employees.AddRange(employees);
            this.shiftType = shift;
        }

        public IValidationResponse AddEmployee(Employee employee)
        {
            if (!employees.Contains(employee))
            {
                employees.Add(employee);
                return new ValidationResponse(true, "Added successfully.");
            }
            else
            {
                return new ValidationResponse(false, "Could not be registered.");
            }
        }

        public IValidationResponse RemoveEmployee(Employee employee)
        {
            bool result = employees.Remove(employee);
            string message;
            if (result)
            {
                message = "Succesfully removed.";
            }
            else
            {
                message = "Employee could not be found.";
            }
            return new ValidationResponse(result, message);
        }

        public IParameterValueCollection GetParameterArgs()
        {
            var args = new ParameterValueCollection();
            args.Add("id", id);
            args.Add("shiftType", (int)shiftType);
            args.Add("date", date);

            return args;
        }

        public bool Equals(Shift? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return ID == other.ID;
        }
    }
}
