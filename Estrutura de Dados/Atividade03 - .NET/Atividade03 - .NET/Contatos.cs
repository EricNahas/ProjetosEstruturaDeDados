using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    internal class Contatos
    {
        public List<Contato> agenda = new List<Contato>();

        public bool adicionar(Contato c)
        {
            bool retorno = false;
            int verificar = 0;

            foreach (Contato contato in agenda)
            {
                if (contato.Equals(c))
                {
                    verificar++;
                }
            }

            if (verificar == 0)
            {
                this.agenda.Add(c);
                retorno = true;
            }

            return retorno;
        }

        public Contato pesquisar(Contato c)
        {
            Contato retorno = new Contato("", "", new Data(), new Telefone("", ""));
            if (Equals(c))
            {
                foreach (Contato contato in agenda)
                {
                    if (contato.getEmail() == c.getEmail())
                    {
                        retorno = contato;
                        break;
                    }
                }
            }



            return retorno;
        }

        public bool alterar(Contato c)
        {
            int x = this.agenda.IndexOf(pesquisar(c));
            bool retorno = false;

            if (x != -1)
            {
                this.agenda[x].Nome = c.Nome;
                this.agenda[x].DtNasc = c.DtNasc;
                this.agenda[x].Telefones = c.Telefones;
                retorno = true;
            }

            return retorno;
        }

        public bool remover(Contato c)
        {
            int x = this.agenda.IndexOf(pesquisar(c));
            bool retorno = false;

            if (x != -1)
            {
                this.agenda.Remove(pesquisar(c));
                retorno = true;
            }

            return retorno;

        }

        public bool Equals(object contato)
        {
            bool retorno = false;
            foreach (Contato c in agenda)
            {
                if (c.getEmail().Equals(((Contato)contato).getEmail()))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}