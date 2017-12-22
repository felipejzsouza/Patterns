using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Item(int id, string descricao, double preco)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public abstract Item Clone();
    }
}
