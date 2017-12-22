using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Dvd : Item
    {
        public Dvd(int id, string descricao, double preco) : base(id, descricao, preco)
        {
        }

        public override Item Clone()
        {
            Console.WriteLine("Clonando Dvd");
            return (Item)this.MemberwiseClone();
        }
    }
}
