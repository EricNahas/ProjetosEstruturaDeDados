using Atividade06;

Medicamentos atividade06 = new Medicamentos();
int opcao = 0;

static void apagaTela()
{
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}
do
{
    Console.WriteLine("0. Finalizar processo\r\n1. Cadastrar medicamento\r\n2. Consultar medicamento (sintético: informar dados1)\r\n3. Consultar medicamento (analítico: informar dados1 + lotes2)\r\n4. Comprar medicamento (cadastrar lote)\r\n5. Vender medicamento (abater do lote mais antigo)\r\n6. Listar medicamentos (informando dados sintéticos)");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            break;

        case 1:
            string nome1, laboratorio1;
            int id1;
            Console.WriteLine("Nome do medicamento");
            nome1 = Console.ReadLine();
            Console.WriteLine("ID do medicamento");
            id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Laboratório do medicamento");
            laboratorio1 = Console.ReadLine();

            Medicamento m1 = new Medicamento(id1, nome1, laboratorio1);

            atividade06.adicionar(m1);

            Console.WriteLine("Cadastro realizado!");

            apagaTela();

            break;

        case 2:
            int id2;
            Console.WriteLine("ID do medicamento");
            id2 = int.Parse(Console.ReadLine());

            Medicamento m2 = new Medicamento(id2, "", "");

            if (atividade06.pesquisar(m2).Id == id2)
            {
                Console.WriteLine(atividade06.pesquisar(m2).ToString());
            }
            else
            {
                Console.WriteLine("Não há medicamento com esse ID");
            }

            apagaTela();

            break;

        case 3:
            int id3;
            Console.WriteLine("ID do medicamento");
            id3 = int.Parse(Console.ReadLine());

            Medicamento m3 = new Medicamento(id3, "", "");

            if (atividade06.pesquisar(m3).Id == id3)
            {
                Console.WriteLine(atividade06.pesquisar(m3).ToString());

                foreach(Lote l3 in atividade06.pesquisar(m3).Lotes)
                {
                    Console.WriteLine(l3.ToString());
                }
            }
            else
            {
                Console.WriteLine("Não há medicamento com esse ID");
            }

            apagaTela();
            break;

        case 4:
            int id4;
            Console.WriteLine("ID do medicamento");
            id4 = int.Parse(Console.ReadLine());
            Medicamento m4 = new Medicamento(id4, "", "");

            if (atividade06.pesquisar(m4).Id == id4)
            {
                int loteId4, loteQtde4;
                DateTime loteVenc4;

                Console.WriteLine("ID do lote");
                loteId4= int.Parse(Console.ReadLine());
                Console.WriteLine("Qtde do lote");
                loteQtde4= int.Parse(Console.ReadLine());
                Console.WriteLine("Vencimento do lote");
                loteVenc4= DateTime.Parse(Console.ReadLine());

                Lote l4 = new Lote(loteId4, loteQtde4, loteVenc4);
                
                atividade06.ListaMedicamentos.Find(l => l.Id == id4).Lotes.Enqueue(l4);

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Não há medicamento com esse ID");
            }

            apagaTela();

            break;

        case 5:
            int id5, qtde5;
            Console.WriteLine("ID do medicamento");
            id5 = int.Parse(Console.ReadLine());

            Medicamento m5 = new Medicamento(id5, "", "");

            if (atividade06.pesquisar(m5).Id == id5)
            {
                Console.WriteLine("Qtde do medicamento");
                qtde5= int.Parse(Console.ReadLine());

                if (atividade06.ListaMedicamentos.Find(l => l.Id == id5).vender(qtde5))
                {
                    Console.WriteLine("Pedido realizado! Obrigado!");
                }
                else
                {
                    Console.WriteLine("Não temos a quantidade solicitada");
                }
            }
            else
            {
                Console.WriteLine("Não há medicamento com esse ID");
            }

            apagaTela();

            break;

        case 6:
            
            foreach(Medicamento m6 in atividade06.ListaMedicamentos)
            {
                Console.WriteLine(m6.ToString());
                foreach (Lote l6 in m6.Lotes)
                {
                    Console.WriteLine(l6.ToString());
                }
            }

            apagaTela();

            break;

        default:
            Console.WriteLine("Opção indesejada. Redigite.");
            break;
    }
}
while (opcao != 0);
