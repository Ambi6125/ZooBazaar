using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALContracts
{
    public interface IDALContacts
    {
        IValidationResponse CreateContract(IDataProvider contract);
        IValidationResponse AssignContract(IDataProvider relationship);
        IValidationResponse UpdateContract(IDataProvider contract);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmployeeName(string name);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByStatus(bool active);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByType(int hour);
    }
}
