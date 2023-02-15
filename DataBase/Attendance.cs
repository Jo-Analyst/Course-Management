using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Attendance
    {
        private string _connectionString = DbConnectionString.connectionString;
        public int Id { get; set; }
        public int Class_id { get; set; }
        public string Date { get; set; }

        public void Save(DataTable dtAttendanceList)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string sql = "INSERT INTO Attendance VALUES (@date, @class_id); SELECT @@identity";
                    SqlCommand command = new SqlCommand(sql, connection, transaction);
                    command.Parameters.AddWithValue("@date", Date);
                    command.Parameters.AddWithValue("@class_id", Class_id);
                    command.CommandText = sql;

                    ListAttendance listAttendance = new ListAttendance();
                    listAttendance._attendanceId = Convert.ToInt32(command.ExecuteScalar());
                    foreach (DataRow dr in dtAttendanceList.Rows)
                    {
                        listAttendance._presence = bool.Parse(dr["presence"].ToString());
                        listAttendance._studentId = int.Parse(dr["student_id"].ToString());
                        listAttendance.ConfirmPresence(transaction);
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

        public int GetLastDataTableAttendaceAndAddOne()
        {
            int maxTableAttendance = 1;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandText = "SELECT MAX(id) FROM Attendance";
                if (command.ExecuteScalar() != DBNull.Value)
                {
                    maxTableAttendance += Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return maxTableAttendance;
        }
    }
}