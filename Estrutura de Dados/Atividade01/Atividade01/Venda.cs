using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Venda
    {
        private int qtde;
        private double valor;

        public Venda(int qtde, double valor)
        {
            this.qtde = qtde;
            this.valor = valor;
        }

        public Venda()
        {
            this.qtde = 0;
            this.valor = 0;
        }

        public double getValor() { 
            return this.valor * this.qtde; 
        }

        public double valorMedio()
        {
            return this.valor/this.qtde;
        }
    }
}
