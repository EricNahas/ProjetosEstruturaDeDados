using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Escola
    {
        private Curso[] curso = new Curso[5];

        public Curso[] getCurso()
        {
            return curso;
        }

        public Escola() 
        {
            for (int i = 0; i < curso.Length; i++)
            {
                curso[i] = new Curso();
            }
        }

        public bool adicionarCurso(Curso curso)
        {
            bool flag = false;

            for (int i = 0; i < this.curso.Length; i++)
            {
                if (this.curso[i].getID() == -1)
                {
                    this.curso[i] = curso;
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

        public bool removerCurso(Curso curso)
        {
            bool flag = false;

            for (int i = 0; i < this.curso.Length; i++)
            {
                if (this.curso[i].getID() == curso.getID())
                {
                    this.curso[i] = new Curso();
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

        public Curso pesquisarCurso(Curso curso)
        {
            Curso retorno = new Curso();

            for (int i = 0; i < this.curso.Length; i++)
            {
                if (this.curso[i].getID() == curso.getID())
                {
                    retorno = this.curso[i];
                    break;
                }
            }

            return retorno;
        }
    }
}
