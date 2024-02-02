using Atividade2;

int opcao = 0;
Escola teste = new Escola();
Curso curso = new Curso();
Disciplina disciplina = new Disciplina();

do
{
    Console.WriteLine("0. Sair \n1. Adicionar Curso \n2. Pesquisar curso \n3. Remover Curso " +
        "\n4. Adicionar disciplina no curso \n5. Pesquisar disciplina \n6. Remover disciplina do curso \n7. Matricular aluno na disciplina " +
        "\n8. Remover aluno da disciplina \n9. Pesquisar aluno");

    opcao = int.Parse(Console.ReadLine());


    switch(opcao)
    {
        case 0:
            break;

        case 1:
            string nome;
            int id;
            Console.WriteLine("Qual o curso deseja adicionar?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a ID que o curso terá?");
            id = int.Parse(Console.ReadLine());
            Curso novoCurso1 = new Curso(id, nome);

            teste.adicionarCurso(novoCurso1);

            break;

        case 2:
            int id2;
            int verDisciplina = 0;
            Console.WriteLine("Digite o ID do curso");
            id2 = int.Parse(Console.ReadLine());
            Curso novoCurso2 = new Curso(id2);

            if (teste.pesquisarCurso(novoCurso2).getDescricao() == "-1")
            {
                Console.WriteLine("Não há curso com esse ID");
            }
            else
            {
                Console.WriteLine(teste.pesquisarCurso(novoCurso2).getDescricao());
                Console.WriteLine("------------------------");

                Disciplina[] c2 = teste.pesquisarCurso(novoCurso2).getDisciplina();

                for (int i = 0; i < c2.Length; i++)
                {
                    if (c2[i].getID() != -1)
                    {
                        Console.WriteLine(c2[i].getDescricao());
                        verDisciplina++;
                    }
                }
                if (verDisciplina == 0)
                {
                    Console.WriteLine("Não há disciplinas ligadas ao curso");
                }
            }
            
            break;

        case 3:
            int id3;
            Console.WriteLine("Digite o ID do curso que deseja remover");
            id3 = int.Parse(Console.ReadLine());

            Curso novoCurso3= new Curso(id3);

            if(teste.removerCurso(novoCurso3))
            {
                Console.WriteLine("Curso removido!");
            }
            else
            {
                Console.WriteLine("Não foi possível remover o curso");
            }

            

            break;

        case 4:
            int id4;
            string nome4;
            int idCurso4;

            Console.WriteLine("Digite o ID do curso");
            idCurso4= int.Parse(Console.ReadLine());
            Curso c4 = new Curso(idCurso4);

            Console.WriteLine("Digite o ID da disciplina");
            id4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da disciplina");
            nome4 = Console.ReadLine();

            Disciplina d4 = new Disciplina(id4, nome4);

            if(teste.pesquisarCurso(c4).adicionarDisciplina(d4))
            {
                Console.WriteLine("Curso adicionado!");
            }
            else
            {
                Console.WriteLine("Não foi possível adicionar o curso");
            }

            break;

        case 5:
            int id5;
            int idCurso5;
            int qtdeAlunos = 0;

            Console.WriteLine("Digite o ID do curso");
            idCurso5= int.Parse(Console.ReadLine());

            Curso c5 = new Curso(idCurso5);

            Console.WriteLine("Digite o ID da disciplina");
            id5 = int.Parse(Console.ReadLine());

            Disciplina d5 = new Disciplina(id5);

            Aluno[] a5 = teste.pesquisarCurso(c5).pesquisarDisciplina(d5).getAlunos();

            if (teste.pesquisarCurso(c5).pesquisarDisciplina(d5).getID() != -1)
            {
                Console.WriteLine(teste.pesquisarCurso(c5).pesquisarDisciplina(d5).getDescricao());
                Console.WriteLine("---------------------");
                for (int i = 0; i < a5.Length; i++)
                {
                    if (a5[i].getID() != -1)
                    {
                        Console.WriteLine(a5[i].getName());
                    }
                }
                if (qtdeAlunos== 0)
                {
                    Console.WriteLine("Não há alunos nessa disciplina");
                }
            }
            else
            {
                Console.WriteLine("Essa disciplina não existe nesse curso!");
            }

            break;

        case 6:
            int id6;
            int idCurso6;
            int podeRemover = 0;

            Console.WriteLine("Digite o ID do curso");
            idCurso6 = int.Parse(Console.ReadLine());

            Curso c6 = new Curso(idCurso6);

            Console.WriteLine("Digite o ID da disciplina");
            id6 = int.Parse(Console.ReadLine());

            Disciplina d6 = new Disciplina(id6);

            Aluno[] a6 = teste.pesquisarCurso(c6).pesquisarDisciplina(d6).getAlunos();

            for (int i = 0; i < a6.Length; i++)
            {
                if (a6[i].getID() != -1)
                {
                    Console.WriteLine("Não é possível remover a disciplina");
                    break;
                }
            }
            if (podeRemover == 0)
            {
                teste.pesquisarCurso(c6).removerDisciplina(d6);
                Console.WriteLine("Disciplina removida!");
            }

            break;

        case 7:
            int id7;
            string nomeAluno7;
            int idAluno7;
            int idCurso7;

            Console.WriteLine("Digite o ID do curso");
            idCurso7 = int.Parse(Console.ReadLine());
            Curso c7 = new Curso(idCurso7);

            if (teste.pesquisarCurso(c7).getID() != -1)
            {
                Console.WriteLine("Digite o ID da disciplina");
                id7 = int.Parse(Console.ReadLine());
                Disciplina d7 = new Disciplina(id7);

                if (teste.pesquisarCurso(c7).pesquisarDisciplina(d7).getID() != -1)
                {
                    Disciplina a7 = teste.pesquisarCurso(c7).pesquisarDisciplina(d7);

                    Console.WriteLine("Digite o nome do aluno");
                    nomeAluno7 = Console.ReadLine();

                    Console.WriteLine("Digite o id do aluno");
                    idAluno7 = int.Parse(Console.ReadLine());

                    Aluno aluno7 = new Aluno(idAluno7, nomeAluno7, idCurso7);

                    a7.matricularAluno(aluno7);
                }
                else
                {
                    Console.WriteLine("Essa disciplina não existe");
                }
            }
            else
            {
                Console.WriteLine("Esse curso não existe");
            }




            break;

        case 8:
            int idCurso8;
            int idDisciplina8;
            int idAluno8;

            Console.WriteLine("Digite o id do curso");
            idCurso8= int.Parse(Console.ReadLine());
            Curso c8 = new Curso(idCurso8);

            if (teste.pesquisarCurso(c8).getID() != -1)
            {
                Console.WriteLine("Digite o id da disciplina que será removida");
                idDisciplina8 = int.Parse(Console.ReadLine());
                Disciplina d8 = new Disciplina(idDisciplina8);

                Aluno[] a8 = teste.pesquisarCurso(c8).pesquisarDisciplina(d8).getAlunos();

                if (teste.pesquisarCurso(c8).pesquisarDisciplina(d8).getID() != -1)
                {
                    Console.WriteLine("Digite o ID do aluno");
                    idAluno8 = int.Parse(Console.ReadLine());

                    Aluno al8 = new Aluno(idAluno8, "", idCurso8);
                    int cont = 0;

                    for (int i = 0; i < a8.Length; i++)
                    {
                        if (al8.getID() == a8[i].getID())
                        {
                            Console.WriteLine("Aluno desmatriculado!");
                            teste.pesquisarCurso(c8).pesquisarDisciplina(d8).desmatricularAluno(a8[i]);
                            break;
                        }
                        cont++;
                    }
                    if (cont == a8.Length -1)
                    {
                        Console.WriteLine("Esse aluno não está matriculado nessa disciplina");
                    }
                }
                else
                {
                    Console.WriteLine("Disciplina não existe");
                }
            }
            else
            {
                Console.WriteLine("Curso não existe");
            }

            



            break;

        case 9:
            int idAluno9;
            bool mostraNome = false;
            int qtdCursos = 0;

            Console.WriteLine("Digite o ID do aluno");
            idAluno9 = int.Parse(Console.ReadLine());
            Aluno al9 = new Aluno(idAluno9, "", -1);

            Curso[] x = teste.getCurso();

            //Aqui começa o for

            for(int i = 0; i < x.Length; i++)
            {
                Disciplina[] y = x[i].getDisciplina();

                for (int j = 0; j < y.Length; j++)
                {
                    Aluno[] z = y[j].getAlunos();

                    for (int k = 0; k < z.Length; k++) 
                    {
                        if (z[k].getID() == al9.getID() && mostraNome == false)
                        {
                            Console.WriteLine("Aluno: ");
                            Console.WriteLine(z[k].getName());
                            Console.WriteLine("Curso: ");
                            Console.WriteLine(x[i].getDescricao());
                            mostraNome= true;
                        }
                        if (z[k].getID() == al9.getID())
                        {
                            Console.WriteLine("Disciplina: ");
                            Console.WriteLine(y[j].getDescricao());
                            qtdCursos++;
                        }
                    }
                }
            }
            if (qtdCursos == 0)
            {
                Console.WriteLine("Este aluno não está matriculado em nenhuma disciplina!");
            }

            break;

        default: 
            Console.WriteLine("Digite um número válido!");
            break;
    }

}
while (opcao != 0);