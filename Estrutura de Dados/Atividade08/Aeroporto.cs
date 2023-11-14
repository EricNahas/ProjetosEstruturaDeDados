using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08
{
    internal class Aeroporto
    {
        private int id;
        private string nome;
        private Stack<Veiculo> pilhaVeiculos;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Stack<Veiculo> PilhaVeiculos { get => pilhaVeiculos; set => pilhaVeiculos = value; }

        public Aeroporto(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            pilhaVeiculos= new Stack<Veiculo>();
        }

        public Aeroporto()
        {
            id = -1;
        }

        public string mostraGaragem()
        {
            string retorno = "";
            int lotacao = 0;

            foreach (Veiculo v in pilhaVeiculos)
            {
                lotacao += v.QtdLotacao;
            }

            retorno += "Quantidade de veículos: " + this.pilhaVeiculos.Count + "\n" + "Potencial de transporte: " + lotacao;

            return retorno;
        }
    }
}
