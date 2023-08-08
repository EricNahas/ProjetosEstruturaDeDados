using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Disciplina
    {
        private int id;
        private string descricao;
        private Aluno[] alunos = new Aluno[15];

        public Disciplina()
        {
            this.id = -1;
            this.descricao = "-1";
            for (int i = 0; i < alunos.Length; i++)
            {
                this.alunos[i] = new Aluno();
            }
        }

        public Disciplina(int id)
        {
            this.id = id; 
        }

        public Disciplina(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
            for (int i = 0; i < alunos.Length; i++)
            {
                this.alunos[i] = new Aluno();
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

        public Aluno[] getAlunos()
        {
            return alunos;
        }

        public bool matricularAluno(Aluno aluno)
        {
            Curso cursoMatricular = new Curso(aluno.getCurso());
            Aluno[] alunoMatricular = this.getAlunos();
            

            bool flag = false;

            if (aluno.podeMatricular(cursoMatricular))
            {
                for(int i = 0; i < this.getAlunos().Length; i++)
                {
                    if (alunoMatricular[i].getID() != aluno.getID() || alunoMatricular[i].getID() == -1)
                    {
                        this.alunos[i] = aluno;
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }

            return flag;
        }

        public bool desmatricularAluno(Aluno aluno)
        {
            Aluno[] alunoMatricular = this.getAlunos();


            bool flag = false;

            for (int i = 0; i < this.getAlunos().Length; i++)
            {
                if (alunoMatricular[i].getID() == aluno.getID())
                {
                    this.alunos[i] = new Aluno();
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
    }
}
