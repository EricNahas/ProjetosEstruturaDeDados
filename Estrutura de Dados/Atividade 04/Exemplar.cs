using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimo = new List<Emprestimo>();

        internal List<Emprestimo> Emprestimo { get => emprestimo; set => emprestimo = value; }
        public int Tombo { get => tombo; set => tombo = value; }

        public Exemplar(int tombo)
        {
            this.Tombo = tombo;
        }

        public bool emprestar()
        {
            bool flag = false;

            if (disponivel())
            {
                flag = true;
                this.Emprestimo[qtdemprestimos() - 1].DtEmprestimo = DateTime.Now;
            }

            return flag;
        }

        public bool devolver()
        {
            bool flag = false;

            if (!disponivel())
            {
                flag = true;
                this.Emprestimo[qtdemprestimos()].DtDevolucao = DateTime.Now;
            }
            
            return flag;
        }

        public bool disponivel()
        {
            bool flag = false;
            if (this.Emprestimo.Count > 0)
            {
                if (this.Emprestimo[qtdemprestimos()].DtDevolucao.ToString() == "")
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public int qtdemprestimos()
        {
            return this.Emprestimo.Count;
        }
    }
}
