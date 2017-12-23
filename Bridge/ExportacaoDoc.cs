using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ExportacaoDoc : ExportacaoImpl
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando DOC...");
        }
    }
}
