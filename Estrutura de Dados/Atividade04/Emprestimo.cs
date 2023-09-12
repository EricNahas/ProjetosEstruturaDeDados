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

        public Emprestimo(DateTime dtEmprestimo, string vazia)
        {
            this.dtEmprestimo = dtEmprestimo;
            this.DtDevolucao = DateTime.Parse(vazia);
        }

        public Emprestimo(DateTime dtDevolucao)
        {
            this.DtDevolucao = dtDevolucao;
        }

        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
    }
}
