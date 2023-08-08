using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Curso
    {
        private int id;
        private string descricao;
        private Disciplina[] disciplina = new Disciplina[12];

        public Curso()
        {
            this.id = -1;
            this.descricao = "-1";
            for (int i = 0; i < disciplina.Length; i++)
            {
                this.disciplina[i] = new Disciplina();
            }
        }

        public Curso(int id)
        {
            this.id = id;
            this.descricao = "-1";
            for (int i = 0; i < disciplina.Length; i++)
            {
                this.disciplina[i] = new Disciplina();
            }
        }
        
        public Curso(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;

            for (int i = 0; i < disciplina.Length; i++)
            {
                this.disciplina[i] = new Disciplina();
            }
        }

        public int getID()
        {
            return id;
        }
        public string getDescricao()
        {
            return descricao;
        }

        public Disciplina[] getDisciplina()
        {
            return disciplina;
        }

        public bool adicionarDisciplina(Disciplina disciplina)
        {
            bool flag = false;

            for (int i = 0; i < this.disciplina.Length; i++)
            {
                if (this.disciplina[i].getID() == -1)
                {
                    this.disciplina[i] = disciplina;
                    flag= true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }
        public bool removerDisciplina(Disciplina disciplina)
        {
            bool flag = false;

            for (int i = 0; i < this.disciplina.Length; i++)
            {
                if (this.disciplina[i].getID() == disciplina.getID())
                {
                    this.disciplina[i] = new Disciplina();
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

        public Disciplina pesquisarDisciplina(Disciplina disciplina)
        {
            Disciplina retorno = new Disciplina();

            for (int i = 0; i < this.disciplina.Length; i++)
            {
                if (this.disciplina[i].getID() == disciplina.getID())
                {
                    retorno = this.disciplina[i];
                    break;
                }
            }

            return retorno;
        }


    }
}
