﻿using System;
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

        ReasonForAbsence reasonForAbsence = new ReasonForAbsence();

        public void ConfirmPresence(SqlTransaction transaction, string reasonForAbsence)
        {
            try
            {
                string sql = "INSERT INTO ListAttendance VALUES (@presence, @studentId, @attendanceId); SELECT @@identity";
                SqlCommand command = new SqlCommand(sql, transaction.Connection, transaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@presence", _presence);
                command.Parameters.AddWithValue("@studentId", _studentId);
                command.Parameters.AddWithValue("@attendanceId", _attendanceId);
                command.CommandText = sql;

                int listAttendanceId = Convert.ToInt32(command.ExecuteScalar());
                // Motivo de falta
                if (!string.IsNullOrEmpty(reasonForAbsence))
                {
                    this.reasonForAbsence.description = reasonForAbsence;
                    this.reasonForAbsence.listAttendanceId = listAttendanceId;
                    this.reasonForAbsence.DescribeReasonForAbsence(transaction);
                }


            }
            catch
            {
                throw;
            }
        }

        public void UpdatePresence(DataTable dtListPresence)
        {
            using (var connection = new SqlConnection(DbConnectionString.connectionString))
            {

                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string sql = "UPDATE ListAttendance SET presence = @presence WHERE id = @id";
                    foreach (DataRow dr in dtListPresence.Rows)
                    {
                        SqlCommand command = new SqlCommand(sql, connection, transaction);
                        command.Parameters.AddWithValue("@id", int.Parse(dr["listAttendanceId"].ToString()));
                        command.Parameters.AddWithValue("@presence", bool.Parse(dr["presence"].ToString()));
                        command.CommandText = sql;

                        // Motivo de falta
                        if (!string.IsNullOrEmpty(dr["reasonForAbsence"].ToString()))
                        {
                            this.reasonForAbsence.id = string.IsNullOrEmpty(dr["reasonForAbsenceId"].ToString()) ? 0 : int.Parse(dr["reasonForAbsenceId"].ToString());
                            this.reasonForAbsence.description = dr["reasonForAbsence"].ToString();
                            this.reasonForAbsence.listAttendanceId = int.Parse(dr["listAttendanceId"].ToString());
                            this.reasonForAbsence.DescribeReasonForAbsence(transaction);
                            if (bool.Parse(dr["presence"].ToString()) && this.reasonForAbsence.id > 0)
                            {
                                ReasonForAbsence.DeleteReasonForAbsence(transaction, this.reasonForAbsence.id);
                            }
                        }

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

        public DataTable GetStudentAttendanceValueSinceJoined(int student_id)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter("", connection);
                    adapter.SelectCommand.CommandText = $"SELECT students.id, students.name, Classes.name as class, Classes.shift, " +
                        $"(SELECT COUNT(Students.id) FROM ListAttendance AS list INNER JOIN Students ON Students.Id = list.student_id WHERE list.presence = 1  AND Students.active = 1 AND Students.id = {student_id}) AS number_attendance, " +
                        $"(SELECT COUNT(Students.id) FROM ListAttendance AS list INNER JOIN Students ON Students.Id = list.student_id WHERE list.presence = 0 AND Students.active = 1  AND Students.id = {student_id})" +
                        $" AS number_absences FROM ListAttendance AS list INNER JOIN Students ON Students.Id = list.student_id INNER JOIN Classes ON Classes.id = Students.class_id WHERE Students.id = {student_id} AND Students.active = 1 GROUP BY students.id, students.name, Classes.name, Classes.shift";
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

        public DataTable ObtainStudentAttendanceValueSinceTheBeginningOfTheCourse(int class_id)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter("", connection);
                    adapter.SelectCommand.CommandText = $"Select COUNT(Attendance.class_id) AS count_attendance from  Attendance INNER JOIN Classes ON Classes.Id = Attendance.class_id where Attendance.class_id = {class_id}";
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
            using (var connection = new SqlConnection(DbConnectionString.connectionString))
            {
                string sql = $"SELECT l.id AS listAttendance_id, l.presence, s.id AS id, s.name, s.active, c.name AS class, c.shift, s.gender, rfa.id as reasonForAbsence_id, rfa.description FROM Attendance AS a left JOIN ListAttendance AS l ON a.id = l.attendance_id left JOIN Students as s ON s.id = l.student_id left JOIN Classes AS c ON c.id = s.class_id left JOIN Reason_For_Absence AS rfa ON rfa.listAttendance_id = l.Id WHERE a.date = '{date}' AND c.name = '{_class}' ORDER BY s.name ASC";
                var adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.CommandText = sql;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetListPresenceStudentByStudentId(int student_id)
        {
            using (var connection = new SqlConnection(DbConnectionString.connectionString))
            {
                string sql = $"SELECT list.presence, att.date, rfa.description FROM ListAttendance AS list inner  JOIN Attendance AS att ON att.Id = list.attendance_id LEFT JOIN Reason_For_Absence AS rfa ON rfa.listAttendance_id = list.Id  WHERE list.student_id = {student_id};";
                var adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.CommandText = sql;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetListPresenceClass(string @class)
        {
            using (var connection = new SqlConnection(DbConnectionString.connectionString))
            {
                string sql = !string.IsNullOrEmpty(@class) 
                    ? $"SELECT list.presence, att.date, rfa.description, s.name AS nameStudent, cl.name AS class, s.active FROM ListAttendance AS list inner  JOIN Attendance AS att ON att.Id = list.attendance_id LEFT JOIN Reason_For_Absence AS rfa ON rfa.listAttendance_id = list.Id LEFT JOIN Students AS s ON s.Id = list.student_id LEFT JOIN Classes as cl ON CL.Id = s.class_id  WHERE cl.name = '{@class}' ORDER BY s.name;" 
                    : $"SELECT list.presence, att.date, rfa.description, s.name AS nameStudent, cl.name AS class, s.active FROM ListAttendance AS list inner  JOIN Attendance AS att ON att.Id = list.attendance_id LEFT JOIN Reason_For_Absence AS rfa ON rfa.listAttendance_id = list.Id LEFT JOIN Students AS s ON s.Id = list.student_id LEFT JOIN Classes as cl ON CL.Id = s.class_id WHERE s.active = 1 ORDER BY s.name";
                var adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.CommandText = sql;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        static public DataTable GetListAttendanceByStudentId(int studentId, string filteringOption = null)
        {
            using (var connection = new SqlConnection(DbConnectionString.connectionString))
            {
                string sql = string.IsNullOrEmpty(filteringOption)
                    ? $"SELECT Attendance.date, ListAttendance.presence AS presence2, ListAttendance.student_id, Reason_For_Absence.description FROM Attendance LEFT JOIN ListAttendance ON Attendance.Id = ListAttendance.attendance_id LEFT JOIN Reason_For_Absence ON ListAttendance.Id = Reason_For_Absence.listAttendance_id WHERE ListAttendance.student_id = {studentId}"
                    : $"SELECT Attendance.date, ListAttendance.presence AS presence2, ListAttendance.student_id, Reason_For_Absence.description FROM Attendance LEFT JOIN ListAttendance ON Attendance.Id = ListAttendance.attendance_id LEFT JOIN Reason_For_Absence ON ListAttendance.Id = Reason_For_Absence.listAttendance_id WHERE ListAttendance.student_id = {studentId} AND ListAttendance.presence = '{filteringOption}'";
                var adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.CommandText = sql;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}