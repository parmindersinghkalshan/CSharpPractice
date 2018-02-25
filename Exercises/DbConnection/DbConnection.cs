using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }

        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                throw new NullReferenceException("Connection string is null!");
            }

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
