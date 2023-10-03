using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class Medicamento
    {
        private int id;
        private string nome, laboratorio;
        private Queue<Lote> lotes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        internal Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        public Medicamento()
        {
            this.Lotes = new Queue<Lote>();
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            Id = id;
            Nome = nome;
            Laboratorio = laboratorio;
            this.Lotes = new Queue<Lote>();
        }

        public int qtdeDisponivel()
        {
            int retorno = 0;

            foreach (Lote lote in this.Lotes)
            {
                retorno += lote.Qtde;
            }

            return retorno;
        }

        public void comprar(Lote lote)
        {
            this.Lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {
            bool retorno = true;

            if (qtde > qtdeDisponivel())
            {
                retorno = false;
            }
            else
            {
                foreach(Lote x in this.Lotes.ToList())
                {
                    if (qtde >= x.Qtde)
                    {
                        qtde -= x.Qtde;
                        Lotes.Dequeue();
                    }
                    else 
                    {
                        x.Qtde -= qtde;
                        qtde = 0;
                        break;
                    }
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            return this.id + " - " + this.nome + " - " + this.laboratorio + " - " + qtdeDisponivel() + " disponíveis";
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;

            foreach (Lote lote in this.Lotes)
            {
                if (lote.Id.Equals(((Lote)obj).Id))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
