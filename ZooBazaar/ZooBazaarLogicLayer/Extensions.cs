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

            for(int i = 0; i < other.Count(); i++)
            {
                var target = other.ElementAt(i);
                if (list.Contains(target))
                {
                    list.Remove(target);
                }
            }
            return list;
        }
    }
}
