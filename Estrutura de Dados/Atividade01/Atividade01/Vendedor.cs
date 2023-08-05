using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas = new Venda[31];

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;

            for (int i = 0; i < this.asVendas.Length; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public Vendedor()
        {
            this.id = -1;
            this.nome = "";
            this.percComissao = -1;
            
            for(int i = 0; i < this.asVendas.Length; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public Vendedor(int id)
        {
            this.id = id;
            this.nome = "";
            this.percComissao = -1;

            for (int i = 0; i < this.asVendas.Length; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public int getId() { return id; }

        public void registrarVenda(int dia, Venda venda)
        {
            this.asVendas[dia] = venda;
        }

        public double valorVendas()
        {
            double soma = 0;

            for(int i = 0; i < this.asVendas.Length; i ++) {
                
                if (asVendas[i].getValor() != 0)
                {
                    soma += asVendas[i].getValor();
                }
            }
            return soma;
        }

        public double valorComissao()
        {
            return this.percComissao * valorVendas();
        }

        public override string ToString()
        {
            string media = "";

            for (int i = 0; i < asVendas.Length; i++)
            {
                if (asVendas[i].getValor() != 0)
                {
                    media += "Dia " + i + ": " + (asVendas[i].valorMedio()).ToString("N2") + "\n";
                }
            }
            return "ID: " + this.id + "\nNome: " + this.nome + "\nVendas: R$ " + valorVendas() + "\nComissão: R$ " + valorComissao() + "\n" + media;
        }

        public bool haVenda(Vendedor v)
        {
            bool flag = false;
            for (int i = 0; i < asVendas.Length; i++)
            {
                if (this.asVendas[i].getValor() != 0)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public string listagemVendedores(int x)
        {
            string retorno = "-";

            if (asVendas[x].getValor() != 0)
            {
                retorno = "ID: " + this.id + "\nNome: " + this.nome + "\nVendas: R$ " + valorVendas() + "\nComissão: R$ " + valorComissao();
            }
            
            return retorno;
        }
    }
}
