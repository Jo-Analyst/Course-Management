using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Content
    {
        public int Id { get; set; }
        public string Wording { get; set; }
        public string Matter { get; set; }
        public string Date { get; set; }
        public int Class_id { get; set; }
        private string connectionString = DbConnectionString.connectionString;

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = Id == 0
                    ? "INSERT INTO Contents VALUES (@wording, @matter, @date, @classId)"
                    : "UPDATE Contents SET wording = @wording, matter = @matter, Date = @Date, class_id = @classId WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@wording", Wording);
                command.Parameters.AddWithValue("@matter", Matter);
                command.Parameters.AddWithValue("@date", Date);
                command.Parameters.AddWithValue("@classId", Class_id);
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

        public void Delete()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Contents WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@wording", Wording);
                command.Parameters.AddWithValue("@classId", Class_id);
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
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT c.id, c.wording, c.matter, c.date, c.class_id, cl.name AS class FROM Contents AS c INNER JOIN Classes AS cl ON C.class_id = cl.id";
                    var adapter = new SqlDataAdapter(sql, connection);
                    adapter.SelectCommand.CommandText = sql;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
