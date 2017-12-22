using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlFactory : DbFactory
    {
        public override DbConnection createConnection()
        {
            return new SqlConnection();
        }

        public override DbCommand createCommand()
        {
            return new SqlCommand();
        }
    }
}
