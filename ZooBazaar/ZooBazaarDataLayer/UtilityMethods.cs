using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer
{
    public static class UtilityMethods
    {
        public static string ConvertDayToString(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return "sunday";
                case DayOfWeek.Monday:
                    return "monday";
                case DayOfWeek.Tuesday:
                    return "tuesday";
                case DayOfWeek.Wednesday:
                    return "wednesday";
                case DayOfWeek.Thursday:
                    return "thursday";
                case DayOfWeek.Friday:
                    return "friday";
                case DayOfWeek.Saturday:
                    return "saturday";
                default:
                    throw new ArgumentOutOfRangeException("Not a valid day");
            }
        }
    }
}
