using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Exportacao export = new ExportacaoRefined();
            export.Implementor = new ExportacaoDoc();
            export.Exportar();
            Console.ReadLine();

        }
    }
}
