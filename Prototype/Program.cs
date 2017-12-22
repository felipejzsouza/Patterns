using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro p1 = new Livro(1, "Design Patterns", 20.0);
            Livro c1 = (Livro)p1.Clone();

            Dvd p2 = new Dvd(2, "POO", 30.0);
            Dvd c2 = (Dvd)p2.Clone();

            Console.ReadLine();

        }
    }
}
