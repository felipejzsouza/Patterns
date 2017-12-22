using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            DbFactory factory = new SqlFactory();

            var conn = factory.createConnection();
            conn.Open();
            var command = factory.createCommand();
            command.Execute();
            Console.ReadLine();
        }
    }
}
