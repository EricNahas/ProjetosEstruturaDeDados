using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas()
        {
            this.ProximoAtendimento = 1;
            FilaSenhas= new Queue<Senha>();

        }

        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }

        public void gerar()
        {
            Senha senha = new Senha(this.proximoAtendimento);
            this.ProximoAtendimento++;
            this.FilaSenhas.Enqueue(senha);
        }
    }
}
