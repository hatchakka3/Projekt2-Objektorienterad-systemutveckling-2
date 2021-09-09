using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DbReset
    {
        public DbReset(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        private DbContext DbContext { get; }

        public void Execute()
        {
            string connectionString = DbContext.Database.Connection.ConnectionString;
            string commandText = "EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'; EXEC sp_MSForEachTable 'DROP TABLE ?';";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception)
                    {
                        // throw;
                    }
                }
            }

            DbContext.Database.Initialize(true);
        }
    }
}
