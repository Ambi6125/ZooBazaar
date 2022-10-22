using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALAccount
{
    public interface IDalAccount
    {
        IValidationResponse AddAccount(IDataProvider account);
        IValidationResponse UpdateAccount(IDataProvider account);
        IValidationResponse DeleteAccount(IDataProvider account);

        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByUsername(string username);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmail(string email);
    }
}
