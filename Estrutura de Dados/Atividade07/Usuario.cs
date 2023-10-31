using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public Usuario() 
        {
            id = -1;
            Nome = "-1";
        }

        public Usuario(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
            Ambientes= new List<Ambiente>();
        }

        public Usuario(int id, string nome, List<Ambiente> ambientes)
        {
            Id = id;
            Nome = nome;
            Ambientes = ambientes;
        }

        public Usuario(int id)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public bool concederPermissao(Ambiente ambiente) 
        {
            bool retorno = true;

            foreach(Ambiente todosAmb in Ambientes) 
            {
                if (ambiente.Id == todosAmb.Id)
                {
                    retorno = false;
                    break;
                }
            }

            if (retorno) { Ambientes.Add(ambiente); }

            return retorno;
            
        }

        public bool revogarPermissao(Ambiente ambiente) 
        {
            bool retorno = false;

            foreach (Ambiente todosAmb in Ambientes)
            {
                if (ambiente.Id == todosAmb.Id)
                {
                    retorno = true;
                    break;
                }
            }

            if (retorno) { Ambientes.Remove(ambiente); }

            return retorno;
        }


    }
}
