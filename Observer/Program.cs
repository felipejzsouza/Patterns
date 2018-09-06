using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Balanco balanco = new Balanco();
            Venda venda = new Venda(balanco);

            balanco.Attach(venda);

            balanco.Iniciar();
            venda.Iniciar();
            balanco.Finalizar();
            venda.Iniciar();
            Console.ReadLine();
        }
    }
}
