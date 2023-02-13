using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Attendance
    {
        public int _id { get; set; }
        public string _date { get; set; }
        public int _classId { get; set; }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ClassStringConnection.ConnectionString))
            {
                string sql = "INSERT INTO Attendance VALUES (@date, @classId)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@date", _date);
                command.Parameters.AddWithValue("@classId", _classId);
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
       
        public DataTable FindAll()
        {
            using (var connection = new SqlConnection(ClassStringConnection.ConnectionString))
            {
                string sql = "SELECT * FROM Attendance AS a INNER JOIN ListAttendance AS l ON a.id = l.attendance_id"; 
                var adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.CommandText = sql;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}