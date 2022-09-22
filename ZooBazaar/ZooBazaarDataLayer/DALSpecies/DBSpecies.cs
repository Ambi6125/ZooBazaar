﻿using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;

namespace ZooBazaarDataLayer.DALSpecies
{
    public class DBSpecies : IDALSpecies
    {
        private IDatabaseCommunicator communicator = new MySqlCommunicator(Data.connectionString);

        private readonly MySqlTable table = new MySqlTable("zb_species");

        public IValidationResponse AddEntry(IDataProvider species)
        {
            InsertQuery query = new InsertQuery(table, species);

            return communicator.Insert(query);
        }

        public IValidationResponse DeleteEntry(IDataProvider species)
        {
            DeleteQuery query = new DeleteQuery(table, "id", species);

            return communicator.Delete(query);
        }

        public IValidationResponse UpdateEntry(IDataProvider species)
        {
            object idValue = species.GetParameterArgs().ElementAt(0);
            MySqlCondition condition = new MySqlCondition("id", idValue, Strictness.MustMatchExactly);
            UpdateQuery query = new UpdateQuery(table, species, condition);

            return communicator.Update(query);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name)
        {
            MySqlCondition condition = new MySqlCondition("speciesName", name, Strictness.MustBeSimilar);
            SelectQuery query = new SelectQuery(table, "*", condition);

            return communicator.Select(query);
        }
    }
}
