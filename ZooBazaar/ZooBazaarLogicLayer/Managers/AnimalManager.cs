﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarDataLayer.DALSpecies;

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
            SpeciesManager sm = new SpeciesManager(new DBSpecies());
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
    }
}