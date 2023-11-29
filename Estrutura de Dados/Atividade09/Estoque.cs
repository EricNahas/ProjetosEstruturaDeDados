using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Estoque
    {
        private int id;
        private Tipo_item tipo_item;
        private Stack<Item> retorno;

        public int Id { get => id; set => id = value; }
        internal Tipo_item Tipo_item { get => tipo_item; set => tipo_item = value; }
        internal Stack<Item> Retorno { get => retorno; set => retorno = value; }

        public Estoque(int id, Tipo_item tipo_item)
        {
            Id = id;
            Tipo_item = tipo_item;
            retorno = new Stack<Item>();
        }

        public Estoque(int id, Tipo_item tipo_item, Stack<Item> retorno)
        {
            Id = id;
            Tipo_item = tipo_item;
            Retorno = retorno;
        }
    }
}
