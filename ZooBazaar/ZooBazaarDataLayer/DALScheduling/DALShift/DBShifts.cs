using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyTools.MySqlDatabaseTools;
using EasyTools.MySqlDatabaseTools.Queries;
using EasyTools.MySqlDatabaseTools.Tables;
using EasyTools.Validation;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ZooBazaarDataLayer.DALScheduling.DALShift
{
    public class DBShifts : IDalShift
    {
        private readonly MySqlTable shifts = new MySqlTable("zb_shifts");
        private readonly MySqlTable intersection = new MySqlTable("zb_employeeshifts");
        private readonly IDatabaseCommunicator database = new MySqlCommunicator(Data.connectionString);


        /// <summary>
        /// Joins the entire shift table with the entire Employees table
        /// </summary>
        private MySqlTable FullJoin => shifts
                .Join(Join.Inner, "zb_employeeShifts", "zb_shifts.id = shiftId")
                .Join(Join.Inner, "zb_employees", "zb_employeeshifts.employeeId = zb_employees.id");

        public IValidationResponse Add(IDataProvider shift)
        {
            InsertQuery q = new InsertQuery(shifts, shift);
            return database.Insert(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetBetween(DateTime start, DateTime end)
        {
            var result = new List<IReadOnlyParameterValueCollection>();
            string query = $"SELECT zb_shifts.*, zb_employees.* FROM {FullJoin} WHERE date >= @MinDate AND date < @MaxDate ORDER BY zb_shifts.id";
            MySqlConnection conn = new MySqlConnection(Data.connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MinDate", start);
            cmd.Parameters.AddWithValue("MaxDate", end);
            using (cmd)
            {
                try
                {
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        int dbshiftType = reader.GetInt32("shiftType");
                        DateTime dbdate = reader.GetDateTime("date");

                        ParameterValueCollection args = new ParameterValueCollection();
                        args.Add("id", id);
                        args.Add("shiftType", dbshiftType);
                        args.Add("date", dbdate);
                        result.Add(args);
                    }
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return result;
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByDate(DateTime date)
        {
            MySqlCondition condition = new MySqlCondition("date", date, Strictness.MustMatchExactly);
            SelectQuery q = new SelectQuery(FullJoin, "zb_shifts.*, zb_employees.*", condition);
            return database.Select(q);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByEmployee(int employeeId)
        {

            MySqlCondition employeeFilter = new MySqlCondition("employeeId", employeeId, Strictness.MustMatchExactly);

            SelectQuery selectQuery = new SelectQuery(FullJoin, "zb_shifts.*, zb_employees.*", employeeFilter);

            return database.Select(selectQuery);
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByTime(DateTime date, int shiftType)
        {
            var parameters = new List<ParameterValueCollection>();
            string query = "SELECT * FROM zb_shifts WHERE date = @date AND shiftType = @type";
            MySqlConnection conn = new MySqlConnection(Data.connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("date", date.Date);
            cmd.Parameters.AddWithValue("type", shiftType);
            using (cmd)
            {
                try
                {
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        int dbshiftType = reader.GetInt32("shiftType");
                        DateTime dbdate = reader.GetDateTime("date");

                        ParameterValueCollection args = new ParameterValueCollection();
                        args.Add("id", id);
                        args.Add("shiftType", dbshiftType);
                        args.Add("date", dbdate);
                        parameters.Add(args);
                    }
                }
                finally
                {
                    if(conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return parameters;
        }

        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesFromShift(int id)
        {
            MySqlTable table = new MySqlTable("zb_employeeshifts").Join(Join.Inner, "zb_employees", "employeeId = id");
            MySqlCondition condition = new MySqlCondition("shiftId", id, Strictness.MustMatchExactly);
            SelectQuery query = new SelectQuery(table, "zb_employees.*", condition);
            return database.Select(query);
        }

        public IReadOnlyCollection<int> GetIdsOnDate(DateTime date)
        {
            MySqlCondition condition = new MySqlCondition("date", date, Strictness.MustMatchExactly);
            SelectQuery query = new SelectQuery(shifts, "id", condition);
            List<int> resultList = new List<int>();
            var response = database.Select(query);
            foreach(var result in response)
            {
                int shiftId = result.GetValueAs<int>("id");
            }
            return resultList;
        }

        public int GetMostRecentId()
        {
            int result = -1;
            string query = "SELECT id FROM zb_shifts ORDER BY id desc LIMIT 1";
            MySqlConnection conn = new MySqlConnection(Data.connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            using (cmd)
            {
                try
                {
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return result;
        }

        public IValidationResponse RegisterEmployee(ShiftEmployeeRelationShip data)
        {
            InsertQuery query = new InsertQuery(intersection, data);
            return database.Insert(query);
        }

        public IValidationResponse RemoveEmployee(ShiftEmployeeRelationShip data)
        {
            string query = "DELETE FROM zb_employeeshifts WHERE employeeId = @empId AND shiftId = @shiftId";

            using (MySqlConnection connection = new MySqlConnection(Data.connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("empId", data.EmployeeId);
                cmd.Parameters.AddWithValue("shiftId", data.ShiftId);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return new ValidationResponse(false, ex.Message);
                }
                finally
                {
                    if(connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                    connection.Dispose();
                }
            }
            return new ValidationResponse(true, "Succesfully removed");
        }
    }
}
