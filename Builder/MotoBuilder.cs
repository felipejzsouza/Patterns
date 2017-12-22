using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MotoBuilder : VeiculoBuilder
    {

        public MotoBuilder()
        {
            _veiculo = new Veiculo("Motocicleta");
        }
        public override void BuildMotor()
        {
            _veiculo["motor"] = "297cc";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "2";
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "0";
        }
    }
}
