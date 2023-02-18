using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBase
{
    public class Backup
    {
        public void GenerateBackup(string path)
        {
            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionString))
            {
                string sql = $"BACKUP DATABASE dbAttendanceList TO DISK = '{path}'";
                SqlCommand command = new SqlCommand(sql, connection);
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

        public void RestoreDataBase(string path)
        {
            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionStringMaster))
            {
                string sql = $"RESTORE DATABASE dbAttendanceList FROM DISK = '{path}'";
                SqlCommand command = new SqlCommand(sql, connection);
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
