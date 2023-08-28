using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    internal class Contato
    {
        private string email, nome;
        private int idade;
        private Data dtNasc;
        private List<Telefone> telefones = new List<Telefone>();

        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        internal List<Telefone> Telefones { get => telefones; set => telefones = value; }

        public void setTelefone(Telefone t)
        {
            this.telefones.Add(t);
        }



        public Contato(string email, string nome, Data dtNasc, Telefone telefone)
        {
            this.email = email;
            this.Nome = nome;
            this.DtNasc = dtNasc;
            this.idade = 2023 - dtNasc.getAno();

            setTelefone(telefone);
        }

        public Contato(string email)
        {
            this.email = email;
            this.Nome = "";
        }

        public string getEmail()
        {
            return email;
        }


        public void adicionarTelefone(Telefone t)
        {
            if (t.Principal == true)
            {
                foreach (Telefone telefoneAdd in telefones)
                {
                    telefoneAdd.Principal = false;
                }
            }

            this.Telefones.Add(t);
        }

        public string getTelefonePrincipal()
        {
            string retorno = "";

            foreach (Telefone tel in telefones)
            {
                if (tel.Principal == true)
                {
                    retorno = tel.Numero;
                }
            }

            if (retorno == "")
            {
                retorno = "Número não encontrado";
            }

            return retorno;
        }

    }
}