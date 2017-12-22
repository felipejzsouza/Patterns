using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Livro : Item
    {
        public Livro(int id, string descricao, double preco)
            : base(id, descricao, preco)
        {
        }

        public override Item Clone()
        {
            Console.WriteLine("Clonando Livro");
            return (Item)this.MemberwiseClone();
        }
    }
}
