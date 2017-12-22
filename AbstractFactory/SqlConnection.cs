using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de SqlConnection foi chamado");
        }
    }
}
