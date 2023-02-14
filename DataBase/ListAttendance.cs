using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class ListAttendance
    {
        public int _id { get; set; }
        private string _connectionString = DbConnectionString.connectionString;
        public bool _presence { get; set; }
        public int _studentId { get; set; }
        public int _attendanceId { get; set; }

        public void ConfirmPresence(SqlTransaction transaction)
        {
            try
            {
                string sql = _id == 0
           ? "INSERT INTO ListAttendance VALUES (@presence, @studentId, @attendanceId)"
           : "UPDATE Attendance SET presence = @presence WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@presence", _presence);
                command.Parameters.AddWithValue("@studentId", _studentId);
                command.Parameters.AddWithValue("@attendanceId", _attendanceId);
                command.CommandText = sql;

                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void UpdatePresence()
        {

        }

        public void CountAttendace()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM ListAttendance WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.CommandText = sql;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public DataTable FindAll(string date, string _class)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = $"SELECT  l.id listAttendance_id, l.presence, s.id as student_id, s.name, s.class, s.gender FROM Attendance AS a INNER JOIN ListAttendance AS l ON a.id = l.attendance_id INNER JOIN Students as s ON s.id = l.student_id WHERE a.date = '{date}' AND s.class = '{_class}'";
                var adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.CommandText = sql;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}