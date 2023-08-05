using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public Vendedores(int max)
        {
            this.max = max;
            this.qtde = 0;

            this.osVendedores = new Vendedor[max];
            for (int i = 0; i < max; i++)
            {
                osVendedores[i] = new Vendedor();
            }
        }

        public bool addVendedor(Vendedor v)
        {
            bool flag = true;

            if (this.qtde < this.max)
            {
                this.osVendedores[this.qtde++] = v;
            }
            else
            {
                flag = false;
            }
            return flag;
            
        }

        public bool delVendedor(Vendedor v)
        {

            if (!v.haVenda(searchVendedor(v)))
            {
                for (int i = 0; i < this.max; i++)
                {
                    if (this.osVendedores[i].getId() == v.getId())
                    {
                        for (; i < this.max - 1; i++)
                        {
                            this.osVendedores[i] = this.osVendedores[i + 1];
                        }

                        this.osVendedores[this.max - 1] = new Vendedor();
                        v = new Vendedor();
                        qtde--;

                        break;
                    }
                }
            }
            
            return v.getId() == -1;
        }

        public Vendedor searchVendedor(Vendedor v)
        {

            for (int i = 0; i < this.max; i++)
            {
                if (this.osVendedores[i].getId() == v.getId())
                {
                    v = this.osVendedores[i];
                    break;
                }
                else if (i == this.max - 1)
                {
                    v = new Vendedor();
                }
            }
            return v;
        }

        public bool realizarVenda(int id, int dia, Venda venda)
        {
            bool flag = false;
            for (int i = 0; i < this.max; i++)
            {
                if (this.osVendedores[i].getId() == id)
                {
                    this.osVendedores[i].registrarVenda(dia, venda);
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public string listagemTotal(int x)
        {
            string retorne = "!";

            if (osVendedores[x].getId() != -1)
            {
                retorne = osVendedores[x].listagemVendedores(x+1);
            }
            return retorne;
        }

        public double totalVendas()
        {
            double total = 0;

            for(int i = 0; i < this.max;i++)
            {
                if (osVendedores[i].valorVendas() != 0)
                {
                    total += osVendedores[i].valorVendas();
                }
            }
            return total;
        }
    }
}
