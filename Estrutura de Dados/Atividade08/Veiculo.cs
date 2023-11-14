using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08
{
    internal class Veiculo
    {
        private int id, qtdLotacao, qtdViagem;

        public int Id { get => id; set => id = value; }
        public int QtdLotacao { get => qtdLotacao; set => qtdLotacao = value; }
        public int QtdViagem { get => qtdViagem; set => qtdViagem = value; }

        public Veiculo(int id, int qtdLotacao)
        {
            this.id = id;
            this.qtdLotacao = qtdLotacao;
            this.QtdViagem = 0;
        }
    }
}
