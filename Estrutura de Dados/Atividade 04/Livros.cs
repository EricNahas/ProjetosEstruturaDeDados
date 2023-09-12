using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Livros
    {
        private List<Livro> acervo = new List<Livro> ();

        public void adicionar(Livro livro)
        {
            acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            Livro retorno = new Livro();

            foreach(Livro book in acervo)
            {
                if (book.Titulo == livro.Titulo)
                {
                    retorno = book;
                }
            }

            return retorno;
        }
    }
}
