using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Guiche
    {
        private int id;
        private Queue<Senha> atendimento;

        public Guiche()
        {
            this.Id = 0;
            this.Atendimento = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            this.Id = id;
            this.Atendimento = new Queue<Senha>();
        }

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimento { get => atendimento; set => atendimento = value; }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            bool retorno = false;

            if (filaSenhas.Count > 0) 
            {
                Senha senha = filaSenhas.Dequeue();
                senha.DataAtend = DateTime.Now;
                senha.HoraAtend = DateTime.Now;
                Atendimento.Enqueue(senha);
                retorno = true;
            } 

            return retorno;
        }
    }
}
