using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Veiculo 
    {
        private string _tipo;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Veiculo(string tipo)
        {
            this._tipo = tipo;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("Tipo: {0}", _tipo);
            Console.WriteLine("Motor: {0}", _parts["motor"]);
            Console.WriteLine("Pneus: {0}", _parts["pneus"]);
            Console.WriteLine("Portas: {0}", _parts["portas"]);
        }

    }
}
