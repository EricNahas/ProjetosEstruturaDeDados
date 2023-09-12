using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Livro
    {
        private int isbn;
        private string titulo, autor, editora;
        private List<Exemplar> exemplares = new List<Exemplar>();

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        internal List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }

        public Livro()
        {
            this.Isbn = -1;
            this.titulo = "";
            this.autor = "";
            this.editora = "";
        }

        public Livro(string titulo)
        {
            this.titulo = titulo;
        }

        public Livro (int isbn, string titulo, string autor, string editora)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
        }

        public void adicionarExemplar(Exemplar exemplar)
        {
            Exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
           return Exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int cont = 0;

            foreach(Exemplar exemplar in Exemplares)
            {
                if (exemplar.disponivel())
                {
                    cont++;
                }
            }
            return cont;
        }

        public int qtdeEmprestimos()
        {
            return qtdeExemplares() - qtdeDisponiveis();
        }

        public double percDisponibilidade()
        {
            double retorno;

            try
            {
                retorno = qtdeDisponiveis() / qtdeExemplares();
            }
            catch 
            {
                retorno = 0;
            }

            return retorno;
        }
    }
}
