using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class GoogleCreatorFactory : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoGoogle();
        }
    }
}
