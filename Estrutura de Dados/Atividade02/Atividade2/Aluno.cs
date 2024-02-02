using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Aluno
    {
        private int id;
        private string name;
        private bool matriculado;
        private int curso;

        public Aluno()
        {
            this.id = -1;
            this.name = "-1";
            this.matriculado = false;
            this.curso = -1;
        }
        
        public Aluno(int id, string nome, int curso)
        {
            this.id = id;
            this.name = nome;
            this.matriculado = false;
            this.curso = curso;
        }

        public bool podeMatricular(Curso curso)
        {
            Disciplina[] x = curso.getDisciplina();
            int alunoMatriculado = 0;

            if (this.curso == -1)
            {
                this.matriculado = false;
            }

            else if(curso.getID() == this.curso)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Aluno[] y = x[i].getAlunos();

                    for (int j = 0; j < y.Length; j++)
                    {
                        if (y[j].getID() == this.id)
                        {
                            alunoMatriculado++;
                        }
                    }
                }

                if (alunoMatriculado < 6)
                {
                    this.matriculado = false;
                }
                else
                {
                    matriculado = true;
                }
            } 

            return !matriculado;
        }

        public string getName()
        {
            return name;
        }

        public int getID()
        {
            return id;
        }

        public int getCurso()
        {
            return curso;
        }
    }
}
