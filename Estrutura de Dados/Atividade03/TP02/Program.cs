using TP02;

int opcao = 0;
bool error = false;
Controller teste = new Controller();

do
{

    Console.WriteLine("--------------------------------------\n0. Sair \n1. Adicionar contato \n2. Adicionar telefone ao contato \n3. Pesquisar contato \n4. Alterar contato \n5. Remover contato \n6. Listar contatos\n--------------------------------------");
    do
    {
        try
        {
            opcao = int.Parse(Console.ReadLine());
            error = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "\nPor favor, redigite: ");
            error = true;
        }
    }
    while(error == true);

    Console.Clear();

    switch(opcao)
    {
        case 0:
            break;

        case 1:
            teste.adicionarContatoAgenda();
            break;

        case 2:
            teste.adicionarTelefoneContato();
            break;

        case 3:
            teste.pesquisarContato();
            break;

        case 4:
            teste.alterarContato();
            break;

        case 5:
            teste.removeContato();
            break;

        case 6:
            teste.listarContatos();
            break;

        default:
            Console.WriteLine("Digite um número válido!");
            break;

    }

}
while (opcao != 0);