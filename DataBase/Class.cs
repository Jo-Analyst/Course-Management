using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Shift { get; set; }
        private string connectionString = DbConnectionString.connectionString;

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = Id == 0
                    ? "INSERT INTO Classes VALUES (@name, @shift)"
                    : "UPDATE Classes SET name = @name, shift = @shift WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@shift", Shift);
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

        public DataTable FindByClass(string @class)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string sql = $"SELECT * FROM Classes WHERE name LIKE '%{@class}%'";
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

        public DataTable FindByClassForShift(string shift)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string sql = $"SELECT name FROM Classes WHERE shift = '{shift}'";
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
                using (var connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Classes ORDER BY name ASC";
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

        public void Delete()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Classes WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", Id);
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
