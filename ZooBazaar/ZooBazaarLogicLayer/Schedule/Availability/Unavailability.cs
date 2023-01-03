using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarLogicLayer.Schedule.Availability
{
    public class UnavailabilityData : IDataProvider, IEquatable<UnavailabilityData>
    {
        private readonly Employee employee;
        private readonly DayOfWeek dayOfWeek;
        private readonly ShiftType shiftType;


        public Employee Employee => employee;
        public DayOfWeek DayOfWeek => dayOfWeek;
        public ShiftType ShiftType => shiftType;

        public UnavailabilityData(Employee employee, DayOfWeek dayOfWeek, ShiftType shiftType)
        {
            this.employee = employee;
            this.dayOfWeek = dayOfWeek;
            this.shiftType = shiftType;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            return new ParameterValueCollection
            {
                { "employeeId", employee.ID },
                { "day", UtilityMethods.ConvertDayToString(dayOfWeek) },
                { "shiftType", (int)shiftType }
            };
        }

        public bool Equals(UnavailabilityData other)
        {
            return employee == other.employee && dayOfWeek == other.dayOfWeek && shiftType == other.shiftType;
        }
    }
}
