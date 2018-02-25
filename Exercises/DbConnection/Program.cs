using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("sql connectionstring");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection("oracle connectionstring");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            DbCommand dbCommand = new DbCommand(null);
            dbCommand.Execute();

            Console.ReadLine();
        }
    }
}
