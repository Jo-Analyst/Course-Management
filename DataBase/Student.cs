using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Student
    {
        string _connectionString = DbConnectionString.connectionString;
        public int _id { get; set; }
        public string _name { get; set; }
        public string _class { get; set; }
        public string _gender { get; set; }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = _id == 0
                    ? "INSERT INTO Students (name, class, gender, created_at) VALUES (@name, @class, @gender, @created_at)"
                    : "UPDATE Students SET name = @name, class = @class, gender = @gender, updated_at =  @updated_at WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@name", _name);
                command.Parameters.AddWithValue("@class", _class);
                command.Parameters.AddWithValue("@gender", _gender);
                command.Parameters.AddWithValue("@created_at", DateTime.Now);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
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

        public DataTable FindByName(string field, string option)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = option.ToLower() == "nome" ? $"SELECT * FROM Students WHERE name LIKE '%{field}%'" : $"SELECT * FROM Students WHERE class LIKE '%{field}%'";
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

        public DataTable FindByClass(string @class)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = $"SELECT * FROM Students WHERE class = @class";
                    var adapter = new SqlDataAdapter(sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@class", @class);
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
                using (var connection = new SqlConnection(_connectionString))
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
                using (var connection = new SqlConnection(_connectionString))
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