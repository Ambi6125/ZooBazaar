using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer
{
    public static class Extensions
    {
        public static DateTime FlipDayAndMonth(this DateTime self)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> ExceptIn<T>(this IEnumerable<T> self, IEnumerable<T> other)
        {
            List<T> list = self.ToList();

            foreach (T item in list)
            {
                if (other.Contains(item))
                {
                    list.Remove(item);
                }
            }
            return list;
        }
    }
}
