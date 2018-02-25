using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing sql connection!");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening sql connection!");
        }
    }
}
