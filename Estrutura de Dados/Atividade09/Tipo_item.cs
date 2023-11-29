using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Tipo_item
    {
        private string nome;
        private int id;
        private List<Item> itens;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        internal List<Item> Itens { get => itens; set => itens = value; }

        public Tipo_item(string nome, int id) 
        {
            Nome = nome;
            Id = id;
            itens = new List<Item>();
        }

        public Tipo_item(int id) 
        {
            Id = id;
        }
    }
}
