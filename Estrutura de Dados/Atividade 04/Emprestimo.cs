using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
    }
}
