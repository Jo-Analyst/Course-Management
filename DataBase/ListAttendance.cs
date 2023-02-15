using System;
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
                string sql = "INSERT INTO ListAttendance VALUES (@presence, @studentId, @attendanceId)";
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

        public void UpdatePresence(DataTable dtListPresence)
        {
            using (var connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string sql = "UPDATE ListAttendance SET presence = @presence WHERE id = @id";
                    foreach (DataRow dr in dtListPresence.Rows)
                    {
                        SqlCommand command = new SqlCommand(sql, connection, transaction);
                        command.Parameters.AddWithValue("@id", int.Parse(dr["id"].ToString()));
                        command.Parameters.AddWithValue("@presence", bool.Parse(dr["presence"].ToString()));
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public DataTable GetStudentAttendanceAmount(int student_id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter("", connection);
                    adapter.SelectCommand.CommandText = $"SELECT students.id, students.name, students.class, (SELECT COUNT(Students.id) FROM ListAttendance AS list INNER JOIN Students ON Students.Id = list.student_id WHERE list.presence = 1 AND Students.id = {student_id}) AS number_attendance, (SELECT COUNT(Students.id) FROM ListAttendance AS list INNER JOIN Students ON Students.Id = list.student_id WHERE list.presence = 0  AND Students.id = {student_id}) AS number_absences FROM ListAttendance AS list INNER JOIN Students ON Students.Id = list.student_id where Students.id = {student_id} GROUP BY students.id, students.name, students.class";
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
        
        public DataTable FindAll(string date, string _class)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = $"SELECT  l.id listAttendance_id, l.presence, s.id as student_id, s.name, c.name AS class, c.shift, s.gender FROM Attendance AS a INNER JOIN ListAttendance AS l ON a.id = l.attendance_id INNER JOIN Students as s ON s.id = l.student_id INNER JOIN Classes AS c ON c.id = s.class_id WHERE a.date = '{date}' AND c.name = '{_class}'";
                var adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.CommandText = sql;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}