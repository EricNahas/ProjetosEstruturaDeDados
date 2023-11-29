using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Contrato
    {
        private int id;
        private DateTime agendamentoSaida;
        private DateTime agendamentoRetorno;
        private List<Itens_contrato> listaContrato;
        private bool liberado;

        public int Id { get => id; set => id = value; }
        public DateTime AgendamentoSaida { get => agendamentoSaida; set => agendamentoSaida = value; }
        public DateTime AgendamentoRetorno { get => agendamentoRetorno; set => agendamentoRetorno = value; }
        internal List<Itens_contrato> ListaContrato { get => listaContrato; set => listaContrato = value; }
        public bool Liberado { get => liberado; set => liberado = value; }

        public Contrato(int id, DateTime agendamentoSaida, DateTime agendamentoRetorno, List<Itens_contrato> listaContrato)
        {
            Id = id;
            AgendamentoSaida = agendamentoSaida.Date;
            AgendamentoRetorno = agendamentoRetorno.Date;
            ListaContrato = listaContrato;
            Liberado = false;
        }
    }
}
