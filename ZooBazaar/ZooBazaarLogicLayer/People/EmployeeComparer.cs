using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.People
{
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        private Func<Employee, Employee, bool> _comparisonFunction;
        public EmployeeComparer(Func<Employee, Employee, bool> function)
        {
            _comparisonFunction = function;
        }

        public bool Equals(Employee? x, Employee? y)
        {

            return _comparisonFunction(x, y);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return base.GetHashCode();
        }
    }

    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> Distinct(this IEnumerable<Employee> self, Func<Employee, Employee, bool> predicate)
        {
            return self.Distinct(new EmployeeComparer(predicate));
        }
    }
}
