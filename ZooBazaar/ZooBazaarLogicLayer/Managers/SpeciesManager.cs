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


        public SpeciesManager(IDALSpecies source)
        {
            dataSource = source;
        }

        //HACK: If you need to make crud in a manager, refer to this method.
        public IValidationResponse AddSpecies(Species s)
        {
            return dataSource.AddEntry(s);
        }

        public IReadOnlyCollection<Species> GetSpeciesByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Species> finalResult = new List<Species>();
            ExhibitManager em = new ExhibitManager(new DBExhibit());
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

        public Species GetById(int id)
        {
            var result = dataSource.GetById(id);
            ExhibitManager em = new ExhibitManager(new DBExhibit());
            if(result is null)
            {
                throw new ArgumentException("No species with this id exists");
            }
            
            int? speciesId = result.GetValueAs<int?>("id");
            string name = result.GetValueAs<string>("name");
            string scientificName = result.GetValueAs<string>("scientificName");
            int exhibitId = result.GetValueAs<int>("exhibit");
            Zones.Exhibit exhibit = em.SearchById(exhibitId);
            string unitSize = result.GetValueAs<string>("unitSize");
            int quantity = result.GetValueAs<int>("quantity");

            return new Species(speciesId, name, scientificName, exhibit, unitSize, quantity);
        }
    }
}
