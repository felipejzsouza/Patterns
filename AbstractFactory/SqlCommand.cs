using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute da classe SqlCommand foi chamado");
        }
    }
}
