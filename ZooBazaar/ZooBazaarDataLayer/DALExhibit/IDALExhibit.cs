using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALExhibit
{
    public interface IDALExhibit
    {
        IValidationResponse AddEntry(IDataProvider exhibit);
        IValidationResponse DeleteEntry(IDataProvider exhibit);
        IValidationResponse UpdateEntry(IDataProvider exhibit);

        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByZone(string zone);
        IReadOnlyParameterValueCollection? GetById(int id);
    }
}
