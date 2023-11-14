using Atividade08;

Fretamento fretamento = new Fretamento();
int opcao = 0;

static void apagaTela()
{
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

int id_veiculo = 1, id_aeroporto = 1;

do
{

    Console.WriteLine("0. Finalizar\r\n1. Cadastrar veículo\r\n2. Cadastrar garagem\r\n3. Iniciar jornada\r\n4. Encerrar jornada\r\n5. Liberar viagem de uma determinada origem para um determinado destino\r\n6. Listar veículos em determinada garagem (informando a quantidade de veículos e seu potencial de transporte)\r\n7. Informar quantidade de viagens efetuadas de uma determinada origem para um determinado destino\r\n8. Listar viagens efetuadas de uma determinada origem para um determinado destino\r\n9. Informar quantidade de passageiros transportados de uma determinada origem para um determinado destino ");
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
            if (!fretamento.Jornada)
            {
                int c1Lotacao;
                Console.WriteLine("Qual a lotação do veículo?");
                c1Lotacao = int.Parse(Console.ReadLine());

                Veiculo c1Veiculo = new Veiculo(id_veiculo, c1Lotacao);

                fretamento.Garagem.ListaVeiculo.Add(c1Veiculo);

                Console.WriteLine("Cadastrado!");
                id_veiculo++;
            }
            else
            {
                Console.WriteLine("A jornada deve estar encerrada para adicionar veículos");
            }

            apagaTela();

            break;

        case 2:
            if (!fretamento.Jornada)
            {
                string c2Nome;
                Console.WriteLine("Qual o nome do aeroporto?");
                c2Nome = Console.ReadLine();

                Aeroporto c2Aeroporto = new Aeroporto(id_aeroporto, c2Nome);

                fretamento.Aeroportos.Add(c2Aeroporto);
                id_aeroporto++;
                Console.WriteLine("Cadastrado!");
            }
            else
            {
                Console.WriteLine("A jornada deve estar encerrada para adicionar garagens");
            }

            apagaTela();

            break;

        case 3:

            if (!fretamento.Jornada)
            {
                fretamento.iniciaJornada();
                Console.WriteLine("A jornada foi iniciada");
            }
            else
            {
                Console.WriteLine("A jornada já está iniciada");
            }

            apagaTela();

            break;

        case 4:
            if (fretamento.Jornada)
            {
                Console.WriteLine(fretamento.encerraJornada());
                Console.WriteLine("-------------------------");
                Console.WriteLine("A jornada foi encerrada");
                Console.WriteLine("-------------------------");
            }
            else
            {
                Console.WriteLine("A jornada já está encerrada");
            }

            apagaTela();

            break;

        case 5:
            int c5AeroportoOrigem, c5AeroportoDestino;

            Console.WriteLine("Qual o ID do aeroporto de origem?");
            c5AeroportoOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ID do aeroporto de destino?");
            c5AeroportoDestino = int.Parse(Console.ReadLine());

            if (c5AeroportoOrigem == c5AeroportoDestino)
            {
                Console.WriteLine("É necessário inserir um aeroporto diferente para se locomover");
            }
            else 
            {
                if (fretamento.procuraAeroporto(c5AeroportoOrigem).Id != - 1 && fretamento.procuraAeroporto(c5AeroportoDestino).Id != -1)
                {
                    Aeroporto A1 = fretamento.procuraAeroporto(c5AeroportoOrigem);
                    Aeroporto A2 = fretamento.procuraAeroporto(c5AeroportoDestino);

                    if (fretamento.permiteViagem(A1))
                    {
                        Viagem c5Viagem = new Viagem(A1, A2, A1.PilhaVeiculos.Peek());
                        A2.PilhaVeiculos.Push(A1.PilhaVeiculos.Pop());

                        fretamento.Viagens.Add(c5Viagem);

                        Console.WriteLine("Viagem realizada!");
                    }
                    else
                    {
                        Console.WriteLine("Sem carros disponíveis no aeroporto escolhido");
                    }
                }
                else
                {
                    Console.WriteLine("IDs utilizadas inválidas!");
                }
            }

            apagaTela();

            break;

        case 6:
            int c6Id;
            Console.WriteLine("Informe o ID da garagem desejada");
            c6Id = int.Parse(Console.ReadLine());

            if (fretamento.procuraAeroporto(c6Id).Id != -1)
            {
                Console.WriteLine(fretamento.procuraAeroporto(c6Id).mostraGaragem());
            }
            else
            {
                Console.WriteLine("Garagem com Id inexistente");
            }

            apagaTela();
            break;

        case 7:
            int c7AeroportoOrigem, c7AeroportoDestino;

            Console.WriteLine("Qual o ID do aeroporto de origem?");
            c7AeroportoOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ID do aeroporto de destino?");
            c7AeroportoDestino = int.Parse(Console.ReadLine());


            if (c7AeroportoOrigem == c7AeroportoDestino)
            {
                Console.WriteLine("É necessário inserir um aeroporto diferente para verificar as viagens");
            }
            else
            {
                if (fretamento.procuraAeroporto(c7AeroportoOrigem).Id != -1 && fretamento.procuraAeroporto(c7AeroportoDestino).Id != -1)
                {
                    Aeroporto c7Verifica1 = fretamento.procuraAeroporto(c7AeroportoOrigem);
                    Aeroporto c7Verifica2 = fretamento.procuraAeroporto(c7AeroportoDestino);
                   
                    Console.WriteLine(fretamento.qtdViagemEspecifica(c7Verifica1, c7Verifica2));
                }
                else
                {
                    Console.WriteLine("IDs utilizadas inválidas!");
                }
            }


            apagaTela();
            break;

        case 8:
            int c8AeroportoOrigem, c8AeroportoDestino;

            Console.WriteLine("Qual o ID do aeroporto de origem?");
            c8AeroportoOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ID do aeroporto de destino?");
            c8AeroportoDestino = int.Parse(Console.ReadLine());


            if (c8AeroportoOrigem == c8AeroportoDestino)
            {
                Console.WriteLine("É necessário inserir um aeroporto diferente para verificar as viagens");
            }
            else
            {
                if (fretamento.procuraAeroporto(c8AeroportoOrigem).Id != -1 && fretamento.procuraAeroporto(c8AeroportoDestino).Id != -1)
                {
                    Aeroporto c8Verifica1 = fretamento.procuraAeroporto(c8AeroportoOrigem);
                    Aeroporto c8Verifica2 = fretamento.procuraAeroporto(c8AeroportoDestino);

                    Console.WriteLine(fretamento.listaViagemEspecifica(c8Verifica1, c8Verifica2));
                }
                else
                {
                    Console.WriteLine("IDs utilizadas inválidas!");
                }
            }

            apagaTela();
            break;

        case 9:
            int c9AeroportoOrigem, c9AeroportoDestino;

            Console.WriteLine("Qual o ID do aeroporto de origem?");
            c9AeroportoOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ID do aeroporto de destino?");
            c9AeroportoDestino = int.Parse(Console.ReadLine());


            if (c9AeroportoOrigem == c9AeroportoDestino)
            {
                Console.WriteLine("É necessário inserir um aeroporto diferente para verificar as viagens");
            }
            else
            {
                if (fretamento.procuraAeroporto(c9AeroportoOrigem).Id != -1 && fretamento.procuraAeroporto(c9AeroportoDestino).Id != -1)
                {
                    Aeroporto c9Verifica1 = fretamento.procuraAeroporto(c9AeroportoOrigem);
                    Aeroporto c9Verifica2 = fretamento.procuraAeroporto(c9AeroportoDestino);

                    Console.WriteLine(fretamento.qtdPassageirosViagemEspecifica(c9Verifica1, c9Verifica2));
                }
                else
                {
                    Console.WriteLine("IDs utilizadas inválidas!");
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