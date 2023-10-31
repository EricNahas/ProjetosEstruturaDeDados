using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    internal class Cadastro
    {
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        public Cadastro()
        {
            usuarios= new List<Usuario>();
            ambientes= new List<Ambiente>();
        }

        public void adicionarUsuario(Usuario usuario) 
        {
            usuarios.Add(usuario);
        }

        public bool removerUsuario (Usuario usuario) 
        {
            bool retorno = false;

            foreach (Usuario u in usuarios)
            {
                if (u.Id == usuario.Id)
                {
                    if (u.Ambientes.Count == 0)
                    {
                        retorno = true;
                    }
                    break;
                }
            }

            if (retorno) { usuarios.Remove(usuario); }

            return retorno;
        }

        public Usuario pesquisarUsuario(Usuario usuario) 
        {
            Usuario retorno = new Usuario();
            foreach (Usuario u in usuarios)
            {
                if (u.Id == usuario.Id)
                {
                    retorno = u;
                    break;
                }
            }

            return retorno;
        }

        public void adicionarAmbiente(Ambiente ambiente) 
        { 
            ambientes.Add(ambiente);
        }

        public bool removerAmbiente(Ambiente ambiente) 
        {
            bool retorno = false;

            foreach (Ambiente a in ambientes)
            {
                if (a.Id == ambiente.Id)
                {
                    retorno = true;
                    break;
                }
            }

            if (retorno) { ambientes.Remove(ambiente); }

            return retorno;
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente) 
        {
            Ambiente retorno = new Ambiente();
            foreach (Ambiente a in ambientes)
            {
                if (a.Id == ambiente.Id)
                {
                    retorno = a;
                    break;
                }
            }

            return retorno;
        }

        public void upload() 
        {
        
        }

        public void download() 
        { 
        
        }


    }
}
