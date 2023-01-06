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

namespace ZooBazaarDataLayer.DALScheduling.DALAvailability
{
    public class DBAvailability : IDALAvailability
    {
        private readonly MySqlTable table = new MySqlTable("zb_unavailability");
        private readonly IDatabaseCommunicator database = new MySqlCommunicator(Data.connectionString);


        public IValidationResponse Insert(IDataProvider data)
        {
            InsertQuery query = new InsertQuery(table, data);
            return database.Insert(query);
        }

        public IValidationResponse Remove(IDataProvider data)
        {
            var parameters = data.GetParameterArgs();
            string query = "DELETE FROM zb_unavailability WHERE employeeId = @id AND day = @day AND shifType @shift;";
            using MySqlConnection conn = new MySqlConnection(Data.connectionString);
            using MySqlCommand cmd = new MySqlCommand(query, conn);



            cmd.Parameters.AddWithValue("id", parameters["employeeId"]);
            cmd.Parameters.AddWithValue("day", parameters["day"]);
            cmd.Parameters.AddWithValue("shiftType", parameters["shiftType"]);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                return new ValidationResponse(false, ex.Message);
            }
            finally
            {
                if(conn.State is not System.Data.ConnectionState.Closed)
                    conn.Close();
            }

            return new ValidationResponse(true, "Removed succesfully");
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByDay(DayOfWeek weekday)
        {
            List<IReadOnlyParameterValueCollection> resultData = new List<IReadOnlyParameterValueCollection>();

            string query = "SELECT * FROM zb_unavailability WHERE day = @day";

            string day = UtilityMethods.ConvertDayToString(weekday);

            using MySqlConnection conn = new MySqlConnection(Data.connectionString);
            using MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("day", day);


            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var dataRow = new ParameterValueCollection()
                    {
                        { "employeeId", reader.GetInt32("employeeId") },
                        { "day", reader.GetString("day") },
                        { "shiftType", reader.GetInt32("shiftType") }
                    };
                    resultData.Add(dataRow);
                }

                return resultData;
            }
            finally
            {
                if (conn.State is not System.Data.ConnectionState.Closed)
                    conn.Close();
            }
            
        }
    }
}