using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;
using ZooBazaarDataLayer.DALExhibit;
using ZooBazaarDataLayer.DALSpecies;
using ZooBazaarLogicLayer.Animals;

namespace ZooBazaarLogicLayer.Managers
{
    public class SpeciesManager
    {
        private IDALSpecies dataSource;


        private SpeciesManager(IDALSpecies source)
        {
            dataSource = source;
        }

        public static SpeciesManager CreateForDatabase()
        {
            return new SpeciesManager(new ZooBazaarDataLayer.DALSpecies.DBSpecies());
        }

        public static SpeciesManager CreateForUnitTest()
        {
            throw new NotImplementedException();
        }
        public IValidationResponse AddSpecies(Species s)
        {
            var result = dataSource.AddEntry(s);
            
            return result;
        }

        public IValidationResponse UpdateSpecies(Species s)
        {
            return dataSource.UpdateEntry(s);
        }

        public IValidationResponse DeleteSpecies(Species s)
        {
            return dataSource.DeleteEntry(s);
        }

        public IReadOnlyCollection<Species> GetSpeciesByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Species> finalResult = new List<Species>();
            ExhibitManager em = ExhibitManager.CreateForDatabase();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("speciesName");
                string scientificname = result.GetValueAs<string>("scientificName");
                int exhibitId = result.GetValueAs<int>("exhibit");
                Zones.Exhibit exhibit = em.SearchById(exhibitId);
                string unitsize = result.GetValueAs<string>("unitSize");
                int quantity = result.GetValueAs<int>("quantity");
                Species species = new Species(id, resultname,scientificname, exhibit, unitsize, quantity);
                finalResult.Add(species);
            }
            return finalResult;
        }

        public Species? GetById(int id)
        {
            var result = dataSource.GetById(id);
            ExhibitManager em = ExhibitManager.CreateForDatabase();
            if (result is null)
            {
                return null;
            }
            
            int? speciesId = result.GetValueAs<int?>("id");
            string name = result.GetValueAs<string>("speciesName");
            string scientificName = result.GetValueAs<string>("scientificName");
            int exhibitId = result.GetValueAs<int>("exhibit");
            Zones.Exhibit exhibit = em.SearchById(exhibitId);
            string unitSize = result.GetValueAs<string>("unitSize");
            int quantity = result.GetValueAs<int>("quantity");

            return new Species(speciesId, name, scientificName, exhibit, unitSize, quantity);
        }

        public IReadOnlyCollection<Species> GetSpeciesByZone(string zone)
        {
            List<Species> resultlist = new List<Species>();
            ExhibitManager em = ExhibitManager.CreateForDatabase();
            var zonesResult = em.GetByZone(zone);
            foreach(Zones.Exhibit w in zonesResult)
            {

            }
            throw new NotImplementedException();
        }
    }
}
