using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionExercise
{
    public class DbCommand
    {
        private DbConnection DbConnection;

        public DbCommand(DbConnection dbConnection)
        {
            DbConnection = dbConnection ?? throw new NullReferenceException("Database connection is null!");
        }

        public void Execute()
        {
            DbConnection.OpenConnection();

            Console.WriteLine("Executing a command!");

            DbConnection.CloseConnection();
        }
    }
}
