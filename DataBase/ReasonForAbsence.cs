using System.Data.SqlClient;

namespace DataBase
{
    public class ReasonForAbsence
    {
        public int id { get; set; }
        public string description { get; set; }
        public int listAttendanceId { get; set; }

        public void DescribeReasonForAbsence(SqlTransaction transaction)
        {
            try
            {
                var command = new SqlCommand("", transaction.Connection, transaction);
                command.CommandText = id == 0 ? $"INSERT INTO Reason_For_Absence VALUES ('{description}', {listAttendanceId})" : $"UPDATE Reason_For_Absence SET description = '{description}' WHERE id = {id}";
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        static public void DeleteReasonForAbsence(SqlTransaction transaction, int id)
        {
            try
            {
                var command = new SqlCommand("", transaction.Connection, transaction);
                command.CommandText = $"DELETE FROM Reason_For_Absence WHERE id = {id}";
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
    }
}
