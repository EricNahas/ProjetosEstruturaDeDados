using Atividade07;
using System;


Cadastro atividade07 = new Cadastro();
int opcao = 0;

static void apagaTela()
{
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

int idAmbiente = 1, idUsuario = 1;

do
{ 

    Console.WriteLine(" 0. Sair\r\n 1. Cadastrar ambiente\r\n 2. Consultar ambiente\r\n 3. Excluir ambiente\r\n 4. Cadastrar usuario\r\n 5. Consultar usuario\r\n 6. Excluir usuario\r\n 7. Conceder permissão de acesso ao usuario (informar ambiente e usuário - vincular ambiente ao usuário)\r\n 8. Revogar permissão de acesso ao usuario (informar ambiente e usuário - desvincular ambiente do usuário)\r\n 9. Registrar acesso (informar o ambiente e o usuário - registrar o log respectivo)\r\n10. Consultar logs de acesso (informar o ambiente e listar os logs - filtrar por logs autorizados/negados/todos)");
    try
    {
        opcao = int.Parse(Console.ReadLine());
    }
    catch 
    {
        opcao = 999;
    }


    switch (opcao)
    {
        case 0:
            break;

        case 1:
            string c1nome;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o nome do Ambiente a ser cadastrado");
            Console.WriteLine("-------------------------------------------");
            c1nome = Console.ReadLine();

            Ambiente c1Ambiente = new Ambiente(idAmbiente, c1nome);

            atividade07.adicionarAmbiente(c1Ambiente);

            Console.WriteLine("Adicionado com o id {0}!", idAmbiente);

            idAmbiente++;

            apagaTela();

            break;

        case 2:
            int c2Id;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o ID do Ambiente a ser consultado");
            Console.WriteLine("-------------------------------------------");
            c2Id = int.Parse(Console.ReadLine());

            Ambiente c2Ambiente = new Ambiente(c2Id);

            Ambiente retornoAmbienteC2 = atividade07.pesquisarAmbiente(c2Ambiente);

            if (retornoAmbienteC2.Id != -1)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Nome: " +  retornoAmbienteC2.Name);
                Console.WriteLine("Id: " + retornoAmbienteC2.Id);
                Console.WriteLine("---------------------------------");

                if (retornoAmbienteC2.Logs.Count > 0)
                {
                    Console.WriteLine("Logs: ");
                    foreach (Log l in retornoAmbienteC2.Logs)
                    {
                        Console.WriteLine(l.DataAcesso);
                        Console.WriteLine(" Acesso: " + (l.TipoAcesso ? "Permitido" : "Negado"));
                        Console.WriteLine(" Usuário: " + l.Usuario.Nome);
                        Console.WriteLine(" Id: " + l.Usuario.Id);
                    }
                }
            }
            else
            {
                Console.WriteLine("ID não existente");
            }

            apagaTela();

            break;

        case 3:
            int c3Id;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o ID do Ambiente a ser removido");
            Console.WriteLine("-------------------------------------------");
            c3Id = int.Parse(Console.ReadLine());

            Ambiente c3Ambiente = new Ambiente(c3Id);

            Ambiente retornoAmbienteC3 = atividade07.pesquisarAmbiente(c3Ambiente);

            if (retornoAmbienteC3.Id != -1)
            {
                Console.WriteLine("Ambiente " + retornoAmbienteC3.Name + " removido com sucesso!");
                atividade07.removerAmbiente(retornoAmbienteC3);
            }
            else
            {
                Console.WriteLine("ID não existe");
            }

            apagaTela();

            break;

        case 4:
            string c4nome;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o nome do Usuário a ser cadastrado");
            Console.WriteLine("-------------------------------------------");
            c4nome = Console.ReadLine();

            Usuario c4Usuario = new  Usuario(idUsuario, c4nome);

            atividade07.adicionarUsuario(c4Usuario);

            Console.WriteLine("Adicionado com o id {0}!", idUsuario);

            idUsuario++;

            apagaTela();

            break;

        case 5:
            int c5Id;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o ID do Usuário a ser consultado");
            Console.WriteLine("-------------------------------------------");
            c5Id = int.Parse(Console.ReadLine());

            Usuario c5Usuario = new Usuario(c5Id);

            Usuario retornoUsuarioC5 = atividade07.pesquisarUsuario(c5Usuario);

            if (retornoUsuarioC5.Id != -1)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Nome: " + retornoUsuarioC5.Nome);
                Console.WriteLine("Id: " + retornoUsuarioC5.Id);
                Console.WriteLine("---------------------------------");

                if (retornoUsuarioC5.Ambientes.Count > 0)
                {
                    Console.WriteLine("Ambientes: ");
                    foreach (Ambiente a in retornoUsuarioC5.Ambientes)
                    {
                        Console.WriteLine(" Nome: " + a.Name);
                        Console.WriteLine(" Id: " + a.Id);
                    }
                }
            }
            else
            {
                Console.WriteLine("ID não existente");
            }

            apagaTela();

            break;

        case 6:
            int c6Id;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o ID do Usuário a ser removido");
            Console.WriteLine("-------------------------------------------");
            c6Id = int.Parse(Console.ReadLine());

            Usuario c6Usuario = new Usuario(c6Id);

            Usuario retornoUsuarioC6 = atividade07.pesquisarUsuario(c6Usuario);

            if (retornoUsuarioC6.Id != -1)
            {
                if (atividade07.removerUsuario(retornoUsuarioC6))
                {
                    Console.WriteLine("Usuário " + retornoUsuarioC6.Nome + " removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Um usuário só pode ser removido quando não houver permissões ligadas à ele.");
                }
                
            }
            else
            {
                Console.WriteLine("ID não existe");
            }

            apagaTela();
            break;

        case 7:
            int c7UsuarioId, c7AmbienteId;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o ID do Usuário a se vincular");
            Console.WriteLine("-------------------------------------------");

            c7UsuarioId = int.Parse(Console.ReadLine());
            Usuario c7Usuario = new Usuario(c7UsuarioId);
            Usuario retornoUsuarioC7 = atividade07.pesquisarUsuario(c7Usuario);

            if (retornoUsuarioC7.Id == -1)
            {
                Console.WriteLine("ID não existe");
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Digite o ID do Ambiente a ser vinculado");
                Console.WriteLine("-------------------------------------------");

                c7AmbienteId = int.Parse(Console.ReadLine());
                Ambiente c7Ambiente = new Ambiente(c7AmbienteId);
                Ambiente retornoAmbienteC7 = atividade07.pesquisarAmbiente(c7Ambiente);

                if (retornoAmbienteC7.Id == -1)
                {
                    Console.WriteLine("ID não existe");
                }
                else
                {
                    if (retornoUsuarioC7.concederPermissao(retornoAmbienteC7))
                    {
                        Console.WriteLine("Permissão Concedida!");
                    }
                    else
                    {
                        Console.WriteLine("Permissão não pôde ser concedida. Verifique se o usuário já tem a permissão solicitada.");
                    }
                }
            }


            apagaTela();
            break;

        case 8:
            int c8UsuarioId, c8AmbienteId;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o ID do Usuário a se desvincular");
            Console.WriteLine("-------------------------------------------");

            c8UsuarioId = int.Parse(Console.ReadLine());
            Usuario c8Usuario = new Usuario(c8UsuarioId);
            Usuario retornoUsuarioC8 = atividade07.pesquisarUsuario(c8Usuario);

            if (retornoUsuarioC8.Id == -1)
            {
                Console.WriteLine("ID não existe");
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Digite o ID do Ambiente a ser desvinculado");
                Console.WriteLine("-------------------------------------------");

                c8AmbienteId = int.Parse(Console.ReadLine());
                Ambiente c8Ambiente = new Ambiente(c8AmbienteId);
                Ambiente retornoAmbienteC8 = atividade07.pesquisarAmbiente(c8Ambiente);

                if (retornoAmbienteC8.Id == -1)
                {
                    Console.WriteLine("ID não existe");
                }
                else
                {
                    if (retornoUsuarioC8.revogarPermissao(retornoAmbienteC8))
                    {
                        Console.WriteLine("Permissão Revogada!");
                    }
                    else
                    {
                        Console.WriteLine("Usuário não possui tal permissão para haver necessidade de revogação.");
                    }
                }
            }

            apagaTela();
            break;

        case 9:
            int c9UsuarioId, c9AmbienteId;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite o ID do Usuário");
            Console.WriteLine("-----------------------");

            c9UsuarioId = int.Parse(Console.ReadLine());
            Usuario c9Usuario = new Usuario(c9UsuarioId);
            Usuario retornoUsuarioC9 = atividade07.pesquisarUsuario(c9Usuario);

            if (retornoUsuarioC9.Id == -1)
            {
                Console.WriteLine("ID não existe");
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Digite o ID do Ambiente");
                Console.WriteLine("-------------------------");

                c9AmbienteId = int.Parse(Console.ReadLine());
                Ambiente c9Ambiente = new Ambiente(c9AmbienteId);
                Ambiente retornoAmbienteC9 = atividade07.pesquisarAmbiente(c9Ambiente);

                if (retornoAmbienteC9.Id == -1)
                {
                    Console.WriteLine("ID não existe");
                }
                else
                {
                    bool tipoAcessoC9 = false;

                    foreach(Ambiente a in retornoUsuarioC9.Ambientes)
                    {
                        if (a.Id == retornoAmbienteC9.Id)
                        {
                            tipoAcessoC9 = true;
                        }
                    }

                    Log c9 = new Log(retornoUsuarioC9, tipoAcessoC9);

                    retornoAmbienteC9.Logs.Enqueue(c9);

                    if (tipoAcessoC9)
                    {
                        Console.WriteLine("Usuário {0} tem permissão para acessar o ambiente {1}", retornoUsuarioC9.Nome, retornoAmbienteC9.Name);
                    }
                    else
                    {
                        Console.WriteLine("Usuário {0} não tem permissão para acessar o ambiente {1}", retornoUsuarioC9.Nome, retornoAmbienteC9.Name);
                    }
                }
            }

            apagaTela();
            break;

        case 10:
            int filtroC10 = 0, c10AmbienteId;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite o ID do ambiente");
            Console.WriteLine("-----------------------");

            c10AmbienteId = int.Parse(Console.ReadLine());
            Ambiente c10Ambiente = new Ambiente(c10AmbienteId);
            Ambiente retornoAmbienteC10 = atividade07.pesquisarAmbiente(c10Ambiente);

            if (retornoAmbienteC10.Id == -1)
            {
                Console.WriteLine("ID não existe");
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Deseja filtrar por: ");
                Console.WriteLine("1. Permitidos");
                Console.WriteLine("2. Negados");
                Console.WriteLine("3. Todos");
                Console.WriteLine("-----------------------");
                try
                {
                    filtroC10 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor indesejado. Mostrando todos os resultados.");
                    filtroC10 = 3;
                }

                switch (filtroC10)
                {
                    case 1:
                        Console.WriteLine("Logs Permitidos: ");
                        foreach (Log l in retornoAmbienteC10.Logs)
                        {
                            if (l.TipoAcesso)
                            {
                                Console.WriteLine(" Data de acesso: " + l.DataAcesso);
                                Console.WriteLine(" Usuário: " + l.Usuario.Nome);
                            }
                        }

                        break;

                    case 2:
                        Console.WriteLine("Logs Negados: ");
                        foreach (Log l in retornoAmbienteC10.Logs)
                        {
                            if (!l.TipoAcesso)
                            {
                                Console.WriteLine(" Data de acesso: " + l.DataAcesso);
                                Console.WriteLine(" Usuário: " + l.Usuario.Nome);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Logs: ");
                        foreach (Log l in retornoAmbienteC10.Logs)
                        {
                            Console.WriteLine(" Data de acesso: " + l.DataAcesso);
                            Console.WriteLine(" Usuário: " + l.Usuario.Nome);
                            Console.WriteLine(" Tipo de acesso: " + (l.TipoAcesso ? "Permitido" : "Negado"));
                        }
                        break;
                }

            }
            

            apagaTela();
            break;

        default:
            Console.WriteLine("Opção indesejada. Redigite.");
            apagaTela();
            break;
    }
}
while (opcao != 0);