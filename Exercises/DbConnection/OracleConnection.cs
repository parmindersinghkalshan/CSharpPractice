using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing oracle connection!");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open oracle connection!");
        }
    }
}
