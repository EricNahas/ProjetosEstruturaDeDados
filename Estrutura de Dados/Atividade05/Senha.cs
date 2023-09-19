using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Senha
    {
        private int id;
        private DateTime dataGerac, dataAtend, horaGerac, horaAtend;

        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public Senha(int id) 
        {
            this.id = id;
            this.DataGerac= DateTime.Now;
            this.HoraGerac= DateTime.Now;
        }

        public string dadosParciais()
        {
            string retorno = this.id + " - " + DataGerac.ToShortDateString() + " - " + HoraGerac.ToShortTimeString();
            return retorno;
        }

        public string dadosCompletos()
        {
            string retorno = this.id + " - " + DataGerac.ToShortDateString() + " - " + HoraGerac.ToShortTimeString() + " - " + DataAtend.ToShortDateString() + " - " + HoraAtend.ToShortTimeString();
            return retorno;
        }
    }
}
