using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Itens_contrato
    {
        private Tipo_item itemContrato;
        private int qtd;

        public int Qtd { get => qtd; set => qtd = value; }
        internal Tipo_item ItemContrato { get => itemContrato; set => itemContrato = value; }

        public Itens_contrato(Tipo_item itemContrato, int qtd) 
        {
            ItemContrato= itemContrato;
            Qtd = qtd;
        }
    }
}
