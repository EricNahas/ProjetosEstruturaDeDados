using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class Lote
    {
        private int id, qtde;
        private DateTime venc;

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }

        public Lote()
        {

        }

        public Lote(int id, int qtde, DateTime venc)
        {
            Id = id;
            Qtde = qtde;
            Venc = venc;
        }

        public override string ToString()
        {
            return "ID: " + this.id + " - Disponíveis: " + this.qtde + " - Dt. Venc.: " + this.venc.ToShortDateString();
        }
    }
}
