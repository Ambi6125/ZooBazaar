using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALScheduling.DALShift
{
    public interface IDalShift
    {
        int GetMostRecentId();
        IValidationResponse Add(IDataProvider shift);
        IValidationResponse RegisterEmployee(ShiftEmployeeRelationShip data);
        IValidationResponse RemoveEmployee(ShiftEmployeeRelationShip data);

        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetBetween(DateTime start, DateTime end);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesFromShift(int id);
        IReadOnlyCollection<int> GetIdsOnDate(DateTime date);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByDate(DateTime date);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByTime(DateTime date, int shiftType);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmployee(int employeeId);
    }
}
