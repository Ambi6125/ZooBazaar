using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;
using ZooBazaarDataLayer.DALSpecies;
using ZooBazaarLogicLayer.Animals;

namespace ZooBazaarLogicLayer.Managers
{
    public class SpeciesManager
    {
        private IDALSpecies dataSource;


        public SpeciesManager(IDALSpecies source)
        {
            dataSource = source;
        }

        public IReadOnlyCollection<Species> GetAnimalsByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Species> finalResult = new List<Species>();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("speciesName");
                string scientificname = result.GetValueAs<string>("scientificName");
                //TODO: Make exhibit read from db to put in ctor
                string unitsize = result.GetValueAs<string>("unitSize");
                int quantity = result.GetValueAs<int>("quantity");
                Species species = new Species(id, resultname,scientificname,null, unitsize, quantity);
                finalResult.Add(species);
            }
            return finalResult;
        }
    }
}
