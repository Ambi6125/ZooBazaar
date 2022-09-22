using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;

namespace ZooBazaarDataLayer.DALAnimal
{
    public interface IDalAnimal
    {
        IValidationResponse AddEntry(IDataProvider animal);
        IValidationResponse DeleteEntry(IDataProvider animal);
        IValidationResponse UpdateEntry(IDataProvider animal);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name);
    }
}
