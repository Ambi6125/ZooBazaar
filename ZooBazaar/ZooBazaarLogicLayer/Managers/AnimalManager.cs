using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;
using ZooBazaarLogicLayer.Animals;

namespace ZooBazaarLogicLayer.Managers
{
    public class AnimalManager
    {
        private IDalAnimal dataSource;


        public AnimalManager(IDalAnimal source)
        {
            dataSource = source;
        }


        public IReadOnlyCollection<Animal> GetAnimalsByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Animal> finalResult = new List<Animal>();
            foreach(var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("animalName");
                DateTime birth = result.GetValueAs<DateTime>("birthdate");
                //TODO: Make species read from db to put in ctor
                string status = result.GetValueAs<string>("status");
                Animal animal = new Animal(id, resultname, birth, null, status);
                finalResult.Add(animal);
            }
            return finalResult;
        }
    }
}
