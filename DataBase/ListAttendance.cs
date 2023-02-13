using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class ListAttendance
    {
        public int _id { get; set; }
        public bool _presence { get; set; }
        public int _studentId { get; set; }
        public int _attendanceId { get; set; }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ClassStringConnection.ConnectionString))
            {
                string sql = _id == 0
                    ? "INSERT INTO Attendance VALUES (@presence, @studentId, @attendanceId)"
                    : "UPDATE Attendance SET presence = @presence WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@presence", _presence);
                command.Parameters.AddWithValue("@studentId", _studentId);
                command.Parameters.AddWithValue("@attendanceId", _attendanceId);
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
       
        public void CountAttendace()
        {
            using (SqlConnection connection = new SqlConnection(ClassStringConnection.ConnectionString))
            {
                string sql = "DELETE FROM Attendance WHERE id = @id";
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
    }
}