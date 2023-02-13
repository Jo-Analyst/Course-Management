using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Student
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _class { get; set; }
        public string _gender { get; set; }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ClassStringConnection.ConnectionString))
            {
                string sql = _id == 0
                    ? "INSERT INTO Students VALUES (@name, @class, @gender)"
                    : "UPDATE Students SET name = @name, class = @class, gender = @gender WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@name", _name);
                command.Parameters.AddWithValue("@class", _class);
                command.Parameters.AddWithValue("@gender", _gender);
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
            using (SqlConnection connection = new SqlConnection(ClassStringConnection.ConnectionString))
            {
                string sql = "DELETE FROM Students WHERE id = @id";
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

        public DataTable FindByName(string name)
        {
            try
            {
                using (var connection = new SqlConnection(ClassStringConnection.ConnectionString))
                {
                    string sql = $"SELECT * FROM Students WHERE name LIKE '%{name}%'";
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
        
        public DataTable FindById()
        {
            try
            {
                using (var connection = new SqlConnection(ClassStringConnection.ConnectionString))
                {
                    string sql = $"SELECT * FROM Students WHERE id = {_id}";
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

        public DataTable FindAll()
        {
            try
            {
                using (var connection = new SqlConnection(ClassStringConnection.ConnectionString))
                {
                    string sql = "SELECT * FROM Students";
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