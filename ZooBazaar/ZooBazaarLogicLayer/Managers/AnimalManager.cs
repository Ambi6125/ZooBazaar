using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarDataLayer.DALSpecies;
using EasyTools.Validation;
using EasyTools.MySqlDatabaseTools;

namespace ZooBazaarLogicLayer.Managers
{
    public class AnimalManager
    {
        private IDalAnimal dataSource;

        private AnimalManager(IDalAnimal source)
        {
            dataSource = source;
        }

        public static AnimalManager CreateForDatabase()
        {
            return new AnimalManager(new DBAnimal());
        }

        public static AnimalManager CreateForUnitTest()
        {
            throw new NotImplementedException();
        }

        
        public IReadOnlyCollection<Animal> GetAnimalsByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Animal> finalResult = new List<Animal>();
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            foreach(var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("animalName");
                DateTime birth = result.GetValueAs<DateTime>("birthdate");
                int speciesId = result.GetValueAs<int>("species");
                Species s = sm.GetById(speciesId);
                string status = result.GetValueAs<string>("status");
                Animal animal = new Animal(id, resultname, birth, s, status);
                finalResult.Add(animal);
            }
            return finalResult;
        }
        public IReadOnlyCollection<Animal> GetAnimalsBySpecies(IDataProvider species)
        {
            var queryResult = dataSource.GetAnimalsBySpecies(species);
            List<Animal> finalResult = new List<Animal>();
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("animalName");
                DateTime birth = result.GetValueAs<DateTime>("birthdate");
                int speciesId = result.GetValueAs<int>("species");
                Species s = sm.GetById(speciesId);
                string status = result.GetValueAs<string>("status");
                Animal animal = new Animal(id, resultname, birth, s, status);
                finalResult.Add(animal);
            }
            return finalResult;
        }

        public IValidationResponse UpdateAnimals(Animal a)
        {
            return dataSource.UpdateEntry(a);
        }
        public IValidationResponse CreateAnimal(Animal a)
        {
            return dataSource.AddEntry(a);
        }
        public IValidationResponse DeleteAnimal(Animal a)
        {
            return dataSource.DeleteEntry(a);
        }

        public IValidationResponse ChangeAnimalStatus(Animal a, string status)
        {
            bool changeResult = a.ChangeStatus(status);
            if(changeResult == false)
            {
                return new ValidationResponse(false, "Not a valid status.");
            }

            return dataSource.UpdateEntry(a);
        }
    }
}
