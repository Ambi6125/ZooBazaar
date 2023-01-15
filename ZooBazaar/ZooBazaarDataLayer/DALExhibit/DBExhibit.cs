using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.Validation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALExhibit
{
    public class DBExhibit : IDALExhibit
    {
        private readonly IDatabaseCommunicator communicator = new MySqlCommunicator(Data.connectionString);
        private readonly MySqlTable table = new MySqlTable("zb_exhibits");

        public int Count
        {
            get
            {
                string query = "SELECT count(*) as NumberOfEntries from zb_exhibits;";
                using MySqlConnection conn = new MySqlConnection(Data.connectionString);
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    object response = cmd.ExecuteScalar();
                    int castResponse = Convert.ToInt32(response);
                    return castResponse;
                }
                catch (MySqlException)
                {
                    return 0;
                }
                finally
                {
                    if(conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }
        }

        public IValidationResponse AddEntry(IDataProvider exhibit)
        {
            InsertQuery query = new InsertQuery(table, exhibit);

            return communicator.Insert(query);
        }
        public IValidationResponse UpdateEntry(IDataProvider exhibit)
        {
            int id = exhibit.GetParameterArgs().GetValueAs<int>("id");
            MySqlCondition condition = new MySqlCondition("id", id, Strictness.MustMatchExactly);
            UpdateQuery q = new UpdateQuery(table, exhibit, condition);
            return communicator.Update(q);
        }

        public IValidationResponse DeleteEntry(IDataProvider exhibit)
        {
            DeleteQuery query = new DeleteQuery(table, "id", exhibit);

            return communicator.Delete(query);
        }

        public IReadOnlyParameterValueCollection? GetById(int id)
        {
            MySqlCondition condition = new MySqlCondition("id", id, Strictness.MustMatchExactly);
            SelectQuery query = new SelectQuery(table, "*", condition);

            return communicator.Select(query).FirstOrDefault();
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name)
        {
            MySqlCondition condition = new MySqlCondition("name", "%" + name + "%", Strictness.MustBeSimilar);
            SelectQuery q = new SelectQuery(table, "*", condition);

            return communicator.Select(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByZone(string zone)
        {
            MySqlCondition condition = new MySqlCondition("zone", zone, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(table, "*", condition);

            return communicator.Select(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAll()
        {
            SelectQuery q = new SelectQuery(table, "*");
            return communicator.Select(q);
        }
    }
}
