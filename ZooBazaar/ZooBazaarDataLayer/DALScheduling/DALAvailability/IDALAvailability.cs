using EasyTools.Validation;
using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALScheduling.DALAvailability
{
    public interface IDALAvailability
    {
        IValidationResponse Insert(IDataProvider data);
        IValidationResponse Remove(IDataProvider data);

        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByDay(DayOfWeek weekday);
    }
}
