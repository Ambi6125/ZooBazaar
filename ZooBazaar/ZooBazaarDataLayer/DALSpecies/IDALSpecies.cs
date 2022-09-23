using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;

namespace ZooBazaarDataLayer.DALSpecies
{
    public interface IDALSpecies
    {
        IValidationResponse AddEntry(IDataProvider species);
        IValidationResponse DeleteEntry(IDataProvider species);
        IValidationResponse UpdateEntry(IDataProvider species);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name);
        IReadOnlyParameterValueCollection? GetById(int id);
    }
}
