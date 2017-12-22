using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void Construct(VeiculoBuilder builder)
        {
            builder.BuildMotor();
            builder.BuildPortas();
            builder.BuildPneus();
        }
    }

}
