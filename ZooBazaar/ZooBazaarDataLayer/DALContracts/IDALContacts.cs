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
        //TODO: Be gone
        IValidationResponse AssignContract(IDataProvider relationship);
        IValidationResponse UpdateContract(IDataProvider contract);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmployeeName(string name);
        //TODO: Be gone
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByStatus(bool active);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByType(int hour);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetActiveContracts(DateTime date);
    }
}
