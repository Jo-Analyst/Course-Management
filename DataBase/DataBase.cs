using System.Data.SqlClient;

namespace DataBase
{
    public class DB
    {
        static public void CreateTables()
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("", connection);
                    command.CommandText = "" +
                        "" +
                        "CREATE TABLE [dbo].[Classes] (    [Id]    INT          IDENTITY (1, 1) NOT NULL,    [name]  VARCHAR (50) NULL,    [shift] VARCHAR (50) NULL,    PRIMARY KEY CLUSTERED ([Id] ASC));" +
                        "CREATE TABLE [dbo].[Students] (    [Id]         INT           IDENTITY (1, 1) NOT NULL,    [name]       VARCHAR (100) NOT NULL,    [CPF] VARCHAR(MAX) NULL,   [gender]     VARCHAR (1)   NOT NULL, [active]     TINYINT NOT NULL DEFAULT 1, [level] VARCHAR(5) NULL,    [class_id]   INT           NULL,    [created_at] DATETIME      NOT NULL,    [updated_at] DATETIME      NULL,    PRIMARY KEY CLUSTERED ([Id] ASC),    FOREIGN KEY ([class_id]) REFERENCES [dbo].[Classes] ([Id]) ON DELETE SET NULL);" +
                        "CREATE TABLE [dbo].[Attendance] (    [Id]       INT          IDENTITY (1, 1) NOT NULL,    [date]     VARCHAR (10) NOT NULL,    [class_id] INT          NULL,    PRIMARY KEY CLUSTERED ([Id] ASC),    FOREIGN KEY ([class_id]) REFERENCES [dbo].[Classes] ([Id]) ON DELETE SET NULL);" +
                        "CREATE TABLE [dbo].[Contents] (    [Id]       INT           IDENTITY (1, 1) NOT NULL,    [wording]  VARCHAR (MAX) NOT NULL,    [matter]   VARCHAR (100) NOT NULL,    [Date]     VARCHAR (10)  NOT NULL,    [class_id] INT           NOT NULL,    PRIMARY KEY CLUSTERED ([Id] ASC),    FOREIGN KEY ([class_id]) REFERENCES [dbo].[Classes] ([Id]) ON DELETE CASCADE);" +
                        "" +
                        "CREATE TABLE [dbo].[ListAttendance] (    [Id]            INT     IDENTITY (1, 1) NOT NULL,    [presence]      TINYINT NOT NULL,    [student_id]    INT     NOT NULL,    [attendance_id] INT     NULL,    PRIMARY KEY CLUSTERED ([Id] ASC),    FOREIGN KEY ([student_id]) REFERENCES [dbo].[Students] ([Id]) ON DELETE CASCADE,    FOREIGN KEY ([attendance_id]) REFERENCES [dbo].[Attendance] ([Id]) ON DELETE SET NULL);" +
                        "CREATE TABLE [dbo].[Reason_For_Absence] (    [Id]            INT           IDENTITY (1, 1) NOT NULL,    [description]   VARCHAR (MAX) NOT NULL,    [listAttendance_id] INT           NOT NULL,    PRIMARY KEY CLUSTERED ([Id] ASC),    FOREIGN KEY ([listAttendance_id]) REFERENCES [dbo].[ListAttendance] ([Id]) ON DELETE CASCADE);";
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        
        static public void InsertIntoClassTable()
        {
            try
            {
                using (var connection = new SqlConnection(DbConnectionString.connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("", connection);
                    command.CommandText = 
                        "INSERT INTO Classes VALUES ('Aurora - SQ', 'Manhã');" +
                        "INSERT INTO Classes VALUES ('Entardecer - SQ', 'Tarde');" +
                        "INSERT INTO Classes VALUES ('Pôr do Sol - SQ', 'Noite');" +
                        "INSERT INTO Classes VALUES ('Alvorada - TQ', 'Manhã');" +
                        "INSERT INTO Classes VALUES ('Alvorecer - TQ', 'Tarde');";
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        static public bool ExistsDataBase()
        {
            bool existsDataBase = false;

            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionStringMaster))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Sys.Databases WHERE name = 'dbCourseManagement'", connection);
                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    SqlDataReader dr = comando.ExecuteReader();
                    if (dr.Read())
                    {
                        existsDataBase = true;
                    }

                }
                catch
                {
                    throw;
                }
            }

            return existsDataBase;
        }

        static public void CreateDatabase()
        {
            using (SqlConnection connection = new SqlConnection(DbConnectionString.connectionStringMaster))
            {
                string sql = "CREATE DATABASE dbCourseManagement";
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
