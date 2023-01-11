using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALAnimal
{
    public class MockDALAnimal : IDalAnimal
    {
        
        public IValidationResponse AddEntry(IDataProvider animal)
        {
            return new ValidationResponse(true, string.Empty);
        }

        public IValidationResponse DeleteEntry(IDataProvider animal)
        {
            return new ValidationResponse(true, string.Empty);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAnimalsBySpecies(IDataProvider species)
        {
            return Enumerable.Empty<IReadOnlyParameterValueCollection>().ToArray();
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name)
        {
            return Enumerable.Empty<IReadOnlyParameterValueCollection>().ToArray();
        }

        public IValidationResponse UpdateEntry(IDataProvider animal)
        {
            throw new NotImplementedException();
        }
    }
}
