using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALScheduling.DALShift
{
    public class MockDALShift : IDalShift
    {
        private Dictionary<Tuple<DateTime, int>, IParameterValueCollection> dbTableSimulator = new Dictionary<Tuple<DateTime, int>, IParameterValueCollection>();
        public IValidationResponse Add(IDataProvider shift)
        {
            var values = shift.GetParameterArgs();
            DateTime date = values.GetValueAs<DateTime>("date");
            int type = values.GetValueAs<int>("shiftType");
            if (dbTableSimulator.Any(entry => entry.Key.Item1 == date && entry.Key.Item2 == type))
            {
                return new ValidationResponse(false, "Already exists");
            }
            else
            {
                dbTableSimulator.Add(new(date, type), values);
                return new ValidationResponse(true, "Added");
            }
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetBetween(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByTime(DateTime date, int shiftType)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesFromShift(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<int> GetIdsOnDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public int GetMostRecentId()
        {
            throw new NotImplementedException();
        }

        public IValidationResponse RegisterEmployee(ShiftEmployeeRelationShip data)
        {
            throw new NotImplementedException();
        }

        public IValidationResponse RemoveEmployee(ShiftEmployeeRelationShip data)
        {
            throw new NotImplementedException();
        }
    }
}
