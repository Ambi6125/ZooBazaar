using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALExhibit
{
    public class MockDALExhibit : IDALExhibit
    {
        public IValidationResponse AddEntry(IDataProvider exhibit)
        {
            return new ValidationResponse(true, string.Empty);
        }

        public IValidationResponse DeleteEntry(IDataProvider exhibit)
        {
            return new ValidationResponse(true, string.Empty);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAll()
        {
            return Enumerable.Empty<IReadOnlyParameterValueCollection>().ToArray();
        }

        public IReadOnlyParameterValueCollection? GetById(int id)
        {
            return null;
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name)
        {
            return Enumerable.Empty<IReadOnlyParameterValueCollection>().ToArray();
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByZone(string zone)
        {
            return Enumerable.Empty<IReadOnlyParameterValueCollection>().ToArray();
        }

        public IValidationResponse UpdateEntry(IDataProvider exhibit)
        {
            return new ValidationResponse(true, string.Empty);
        }
    }
}
