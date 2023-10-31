using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class Log
    {
        private DateTime dataAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public Log(Usuario usuario, bool tipoAcesso)
        {
            DataAcesso = DateTime.Now;
            Usuario = usuario;
            TipoAcesso = tipoAcesso;
        }

        public DateTime DataAcesso { get => dataAcesso; set => dataAcesso = value; }
        public bool TipoAcesso { get => tipoAcesso; set => tipoAcesso = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
