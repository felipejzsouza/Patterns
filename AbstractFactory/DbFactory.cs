using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class DbFactory
    {
        public abstract DbConnection createConnection();
        public abstract DbCommand createCommand();
    }
}
