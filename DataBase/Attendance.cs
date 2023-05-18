using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Attendance
    {
        public int Id { get; set; }
        public int Class_id { get; set; }
        public string Date { get; set; }

        public void Save(DataTable dtAttendanceList)
        {
            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionString))
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
                   
                    int attendanceId = Convert.ToInt32(command.ExecuteScalar());
                    listAttendance._attendanceId = attendanceId;

                    foreach (DataRow dr in dtAttendanceList.Rows)
                    {
                        listAttendance._presence = bool.Parse(dr["presence"].ToString());
                        listAttendance._studentId = int.Parse(dr["studenId"].ToString());
                        listAttendance.ConfirmPresence(transaction, dr["reasonForAbsence"].ToString());                       
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

        public int CountPresenceForClass(int class_id)
        {
            int contPresence = 1;

            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandText = $"SELECT Count(Class_id) FROM Attendance WHERE class_id = {class_id}";
                if (command.ExecuteScalar() != DBNull.Value)
                {
                    contPresence = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return contPresence;

        }
    }
}