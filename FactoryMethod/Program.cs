using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new GoogleCreatorFactory();
            creators[1] = new FacebookCreatorFactory();

            foreach(Creator c in creators)
            {
                Autenticacao aut = c.CreateInstance();
                aut.Autenticar();
            }

            Console.ReadLine();
        }
    }
}
