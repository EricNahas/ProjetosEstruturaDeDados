using Atividade01;

int opcao = 0;
int maxRangeVendedores = 10;
Vendedores vendedores = new Vendedores(maxRangeVendedores);



do
{
    Console.WriteLine("0.Sair\n1.Cadastrar vendedor\n2.Consultar vendedor\n3.Excluir vendedor\n4.Registrar venda\n5.Listar vendedores");
    opcao = int.Parse(Console.ReadLine());

    switch(opcao)
    {
        case 0: 
            break;

        case 1:
            string nomeCaso1 = "";
            int idCaso1 = 0;
            double percCaso1 = 0;

            Console.WriteLine("Digite o nome do vendedor: ");
            nomeCaso1 = Console.ReadLine();

            Console.WriteLine("Digite a matrícula do vendedor: ");
            idCaso1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de comissão do vendedor: ");
            percCaso1 = double.Parse(Console.ReadLine());

            Vendedor caso1 = new Vendedor(idCaso1, nomeCaso1, percCaso1);

            if (vendedores.addVendedor(caso1))
            {
                Console.WriteLine("Vendedor adicionado!");
            }
            else
            {
                Console.WriteLine("Não foi possível adicionar o vendedor");
            }

            break;

        case 2:
            int idCaso2;
            Console.WriteLine("Digite o ID do vendedor procurado: ");
            idCaso2 = int.Parse(Console.ReadLine());

            Vendedor caso2 = new Vendedor(idCaso2);

            if (vendedores.searchVendedor(caso2).getId() != -1)
            {
                Console.WriteLine(vendedores.searchVendedor(caso2).ToString());
            }

            

            break;

        case 3:
            int idCaso3;
            Console.WriteLine("Digite o ID do vendedor: ");
            idCaso3= int.Parse(Console.ReadLine());

            Vendedor caso3 = new Vendedor(idCaso3);

            if(vendedores.delVendedor(caso3)) 
            {
                Console.WriteLine("Vendedor excluído!");
            }
            else
            {
                Console.WriteLine("Vendedor não foi excluído!");
            }

            break;

        case 4:
            int idCaso4;
            int diaCaso4;
            int qtdeCaso4;
            double valorCaso4;

            Console.WriteLine("Digite o ID do vendedor: ");
            idCaso4 = int.Parse(Console.ReadLine());

            Vendedor caso4 = new Vendedor(idCaso4);

            if (vendedores.searchVendedor(caso4).getId() != -1)
            {
                Console.WriteLine("Digite o dia da venda: ");
                diaCaso4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantia de produtos vendidos: ");
                qtdeCaso4= int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor dos produtos vendidos: ");
                valorCaso4= double.Parse(Console.ReadLine());

                Venda vendaCaso4 = new Venda(qtdeCaso4, valorCaso4);

                vendedores.realizarVenda(idCaso4, diaCaso4, vendaCaso4);
                    Console.WriteLine("Venda inserida!");
            }
            else
            {
                Console.WriteLine("Não há vendedores com esse ID.");
            }


            break;

        case 5:
            for (int i = 0; i < maxRangeVendedores; i++)
            {
                Console.WriteLine(vendedores.listagemTotal(i));
            }
            Console.WriteLine(vendedores.totalVendas());
            break;

        default:
            Console.WriteLine("Digite um número válido!");
            break;
    }
}
while (opcao != 0);