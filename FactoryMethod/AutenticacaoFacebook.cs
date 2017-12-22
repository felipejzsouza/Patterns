using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AutenticacaoFacebook : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via facebook");
        }
    }
}
