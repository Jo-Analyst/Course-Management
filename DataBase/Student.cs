using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Student
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _cpf{ get; set; }
        public string _level{ get; set; }
        public int _class_id { get; set; }
        public string _gender { get; set; }

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionString))
            {
                string sql = _id == 0
                    ? "INSERT INTO Students (name, class_id, gender, created_at, CPF, level) VALUES (@name, @class_id, @gender, @created_at, @cpf, @level)"
                    : "UPDATE Students SET name = @name, class_id = @class_id, gender = @gender, updated_at =  @updated_at, CPF = @CPF, level = @level  WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@name", _name);
                command.Parameters.AddWithValue("@class_id", _class_id);
                command.Parameters.AddWithValue("@gender", _gender);
                command.Parameters.AddWithValue("@cpf", _cpf);
                command.Parameters.AddWithValue("@level", _level);
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
            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionString))
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

        public DataTable FindByName(string field, string option = "nome")
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    string sql = option.ToLower() == "nome"
                        ? $"SELECT Students.Id, Students.name, Students.gender, Students.created_at, Students.updated_at, Classes.name AS class, Classes.shift, Classes.id AS class_id, Students.CPF, Students.level FROM Students INNER JOIN Classes ON Classes.id = Students.class_id WHERE Students.name LIKE '%{field}%'"
                        : $"SELECT Students.Id, Students.name, Students.gender, Students.created_at, Students.updated_at, Classes.name AS class, Classes.shift, Classes.id AS class_id,  Students.CPF, Students.level FROM Students INNER JOIN Classes ON Classes.Id = Students.class_id WHERE Classes.name LIKE '%{field}%' ORDER BY Classes.name, Students.name";
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

        public DataTable FindByNameForClass(string name, string _class)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    string sql = $"SELECT Students.id, Students.class_id FROM Students INNER JOIN Classes ON Classes.id = Students.class_id WHERE Students.name = '{name}' AND Classes.name = '{_class}'";
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

        static public DataTable FindByClass(string @class)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    string sql = $"SELECT Students.Id, Students.name, Students.gender, Classes.name AS class, Classes.shift, Classes.id AS class_id FROM Students INNER JOIN Classes ON Classes.id = Students.class_id WHERE Classes.name = @class ORDER BY Students.name ASC";
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

        static public DataTable FindById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    string sql = $"SELECT Students.Id, Students.name, Students.gender, Classes.name AS class, Classes.shift, Classes.id AS class_id FROM Students INNER JOIN Classes ON Classes.id = Students.class_id WHERE id = {id}";
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

        static public bool ExistsCPF(string cpf)
        {
            bool existsCPF = false;
            using(var connection = new SqlConnection(DbConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand("", connection);
                    command.CommandText = $"SELECT * FROM Students WHERE cpf = '{cpf}'";
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        existsCPF = true;
                    }
                }
                catch
                {
                    throw;
                }
            }

            return existsCPF;
        }

        public DataTable FindAll()
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    string sql = "SELECT Students.Id, Students.name, Students.gender, Students.created_at, Students.updated_at, Classes.name AS class, Classes.shift, Classes.id AS class_id, Students.CPF, Students.level FROM Students INNER JOIN Classes ON Classes.id = Students.class_id ORDER BY Classes.name, Students.name";
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