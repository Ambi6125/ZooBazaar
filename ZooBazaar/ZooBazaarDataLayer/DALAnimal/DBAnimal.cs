﻿using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using System.Xml.Linq;

namespace ZooBazaarDataLayer.DALAnimal
{
    /// <summary>
    /// Communicates with a database to manipulate animal data
    /// </summary>
    public class DBAnimal : IDalAnimal
    {
        private IDatabaseCommunicator communicator = new MySqlCommunicator(Data.connectionString);

        private readonly MySqlTable table = new MySqlTable("zb_animals");

        public IValidationResponse AddEntry(IDataProvider animal)
        {
            InsertQuery query = new InsertQuery(table, animal);

            return communicator.Insert(query);
        }

        public IValidationResponse DeleteEntry(IDataProvider animal)
        {
            object idValue = animal.GetParameterArgs().ElementAt(0);
            MySqlCondition condition = new MySqlCondition("id", idValue, Strictness.MustMatchExactly);
            UpdateQuery query = new UpdateQuery(table, animal, condition);

            return communicator.Update(query);
        }

        public IValidationResponse UpdateEntry(IDataProvider animal)
        {
            object idValue = animal.GetParameterArgs().ElementAt(0);
            MySqlCondition condition = new MySqlCondition("id", idValue, Strictness.MustMatchExactly);
            UpdateQuery query = new UpdateQuery(table, animal, condition);

            return communicator.Update(query);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name)
        {
            MySqlCondition condition = new MySqlCondition("animalName", "%" + name + "%", Strictness.MustBeSimilar);
            SelectQuery query = new SelectQuery(table, "*", condition);

            return communicator.Select(query);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAnimalsBySpecies(IDataProvider species)
        {
            int idValue = (int)species.GetParameterArgs().ElementAt(0).Value;
            MySqlCondition condition = new MySqlCondition("species", idValue, Strictness.MustMatchExactly);
            SelectQuery query = new SelectQuery(table, "*", condition);

            return communicator.Select(query);
        }
    }
}
