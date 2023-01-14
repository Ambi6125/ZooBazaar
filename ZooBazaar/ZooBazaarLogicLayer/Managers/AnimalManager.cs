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
        private List<Animal> animals = new List<Animal>();
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
            return new AnimalManager(new MockDALAnimal());
        }

        
        public IReadOnlyCollection<Animal> GetAnimalsByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Animal> finalResult = animals.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
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
                if (!finalResult.Any(x => x.ID == id))
                {
                    finalResult.Add(animal);
                    animals.Add(animal);
                }
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
            var response = dataSource.AddEntry(a);
            if (response.Success)
            {
                animals.Add(a);
            }
            return response;
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
