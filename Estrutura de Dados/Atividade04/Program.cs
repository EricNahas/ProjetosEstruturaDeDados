using ConsoleApp1;

int opcao = 0;
Livros viewLivros = new Livros();

do
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("0. Sair \n1. Adicionar livro \n2. Pesquisar livro (sintético) \n3. Pesquisar livro (analítico) \n4. Adicionar exemplar \n5. Registrar empréstimo \n6. Registrar devolução");
    Console.WriteLine("-----------------------------------------");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("-----------------------------------------");

    switch (opcao)
    {
        case 1:
            string titulo, autor, editora;
            int codigo;

            Console.WriteLine("Qual o código?");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o título?");
            titulo = Console.ReadLine();
            Console.WriteLine("Qual o autor?");
            autor = Console.ReadLine();
            Console.WriteLine("Qual a editora?");
            editora = Console.ReadLine();

            Livro livro1 = new Livro(codigo, titulo, autor, editora);

            viewLivros.adicionar(livro1);

            Console.WriteLine("Adicionado!");

            break;

        case 2:
            string titulo2;
            Console.WriteLine("Informe o titulo do livro: ");
            titulo2 = Console.ReadLine();
            Livro livro2 = new Livro(titulo2);

            Livro pesquisaLivro2 = viewLivros.pesquisar(livro2);

            if (pesquisaLivro2.Titulo != "")
            {
                Console.WriteLine("Título: " + pesquisaLivro2.Titulo);
                Console.WriteLine("Editora: " + pesquisaLivro2.Editora);
                Console.WriteLine("Autor: " + pesquisaLivro2.Autor);

                Console.WriteLine("Quantidade de Exemplares: " + pesquisaLivro2.qtdeExemplares());
                Console.WriteLine("Exemplares disponíveis: " + pesquisaLivro2.qtdeDisponiveis());
                Console.WriteLine("Quantidade de empréstimos: " + pesquisaLivro2.qtdeEmprestimos());
                Console.WriteLine("Percentual de disponibilidade: " + (pesquisaLivro2.percDisponibilidade() * 100).ToString("N2") + "%");
            }
            else
            {
                Console.WriteLine("Título não existe.");
            }

            break;

        case 3:
            string titulo3;
            Console.WriteLine("Informe o titulo do livro: ");
            titulo3 = Console.ReadLine();
            Livro livro3 = new Livro(titulo3);

            Livro pesquisaLivro3 = viewLivros.pesquisar(livro3);

            if (pesquisaLivro3.Titulo != "")
            {
                Console.WriteLine("Título: " + pesquisaLivro3.Titulo);
                Console.WriteLine("Editora: " + pesquisaLivro3.Editora);
                Console.WriteLine("Autor: " + pesquisaLivro3.Autor);

                Console.WriteLine("Quantidade de Exemplares: " + pesquisaLivro3.qtdeExemplares());
                Console.WriteLine("Exemplares disponíveis: " + pesquisaLivro3.qtdeDisponiveis());
                Console.WriteLine("Quantidade de empréstimos: " + pesquisaLivro3.qtdeEmprestimos());
                Console.WriteLine("Percentual de disponibilidade: " + (pesquisaLivro3.percDisponibilidade() * 100).ToString("N2") + "%");

                foreach (Exemplar exemplar3 in pesquisaLivro3.Exemplares)
                {
                    foreach (Emprestimo emprestimo3 in exemplar3.Emprestimo)
                    {
                        Console.WriteLine("Exemplar: " + exemplar3.Tombo);
                        Console.WriteLine("Data de Empréstimo: " + emprestimo3.DtEmprestimo);
                        Console.WriteLine("Data de Devolução: " + emprestimo3.DtDevolucao);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Título não existe.");
            }
            break;

        case 4:
            string titulo4;
            Console.WriteLine("Informe o titulo do livro: ");
            titulo4 = Console.ReadLine();
            Livro livro4 = new Livro(titulo4);

            Livro pesquisaLivro4 = viewLivros.pesquisar(livro4);

            if (pesquisaLivro4.Titulo != "")
            {
                int tombo4;
                Console.WriteLine("Informe o tombo do exemplar: ");
                tombo4 = int.Parse(Console.ReadLine());
                Exemplar exemplar4 = new Exemplar(tombo4);
                pesquisaLivro4.adicionarExemplar(exemplar4);
            }
            else
            {
                Console.WriteLine("Título inexistente");
            }
            break;

        case 5:
            string titulo5;
            Console.WriteLine("Informe o titulo do livro: ");
            titulo5 = Console.ReadLine();
            Livro livro5 = new Livro(titulo5);

            Livro pesquisaLivro5 = viewLivros.pesquisar(livro5);

            if (pesquisaLivro5.Titulo != "")
            {
                if (pesquisaLivro5.qtdeDisponiveis() == 0)
                {
                    Console.WriteLine("Não temos nenhum exemplar disponível");
                }
                else
                {
                    foreach (Exemplar ex5 in pesquisaLivro5.Exemplares)
                    {
                        if (ex5.emprestar())
                        {
                            Console.WriteLine("O seu exemplar é o de tombo: " + ex5.Tombo);
                            break;
                        }
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Título não existe");
            }

                break;

        case 6:
            string titulo6;
            int tombo6;
            Console.WriteLine("Informe o titulo do livro: ");
            titulo6 = Console.ReadLine();
            Livro livro6 = new Livro(titulo6);

            Livro pesquisaLivro6 = viewLivros.pesquisar(livro6);

            if (pesquisaLivro6.Titulo != "")
            {
                if (pesquisaLivro6.qtdeEmprestimos() == 0)
                {
                    Console.WriteLine("Não há devoluções a serem feitas");
                }
                else
                {
                    Console.WriteLine("Informe o tombo do exemplar: ");
                    tombo6 = int.Parse(Console.ReadLine());
                    Exemplar ex6 = new Exemplar(tombo6);

                    foreach(Exemplar exemplar6 in pesquisaLivro6.Exemplares)
                    {
                        if (exemplar6.Tombo == ex6.Tombo)
                        {
                            exemplar6.devolver();
                            Console.WriteLine("Tombo " + tombo6 + " devolvido");
                            break;
                        }

                        if (exemplar6 == pesquisaLivro6.Exemplares[pesquisaLivro6.Exemplares.Count - 1])
                        {
                            Console.WriteLine("Tombo " + tombo6 + " não existe");
                        }
                    }

                }

            }
            else
            {
                Console.WriteLine("Título não existe");
            }
            break;

        default:
            Console.WriteLine("Adeus");
            break;
    }
}
while (opcao != 0);