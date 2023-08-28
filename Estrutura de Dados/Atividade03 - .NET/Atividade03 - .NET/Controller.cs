using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    internal class Controller
    {
        Contatos contatos1 = new Contatos();

        public void adicionarContatoAgenda()
        {
            string nome, email, tipo, numero;
            Data data;
            int dia, mes, ano;
            Telefone telefone;

            Console.WriteLine("Digite o nome do contato: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o email do contato: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite o dia de nascimento: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes de nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            Data d1 = new Data();
            d1.setData(dia, mes, ano);

            Console.WriteLine("Digite o tipo de telefone: ");
            tipo = Console.ReadLine();
            Console.WriteLine("Digite o numero de telefone: ");
            numero = Console.ReadLine();

            Telefone t1 = new Telefone(tipo, numero);

            Contato c1 = new Contato(email, nome, d1, t1);

            if (contatos1.adicionar(c1))
            {
                Console.WriteLine("Contato adicionado!");
            }
            else
            {
                Console.WriteLine("Contato não adicionado");
            }
            Console.ReadKey();
            Console.Clear();
        }


        public void adicionarTelefoneContato()
        {
            string email, tipo, numero, p;
            bool principal;
            Console.WriteLine("Digite o email do contato: ");
            email = Console.ReadLine();

            Contato c2 = new Contato(email);

            if (contatos1.pesquisar(c2).getEmail() != "")
            {
                Console.WriteLine("Digite o numero de telefone: ");
                tipo = Console.ReadLine();
                Console.WriteLine("Digite o tipo de telefone: ");
                numero = Console.ReadLine();
                Console.WriteLine("Ele será o número principal? (s/n)");
                p = Console.ReadLine();

                if (p == "s") { principal = true; } else { principal = false; }

                Telefone t2 = new Telefone(tipo, numero, principal);

                int x = contatos1.agenda.IndexOf(contatos1.pesquisar(c2));
                contatos1.agenda[x].adicionarTelefone(t2);

                Console.WriteLine("Inserido!");
            }
            else
            {
                Console.WriteLine("O e-mail declarado não existe");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public string pesquisarContato()
        {
            string email, rstring = "";
            bool retorno = false;
            Console.WriteLine("Digite o e-mail do contato: ");
            email = Console.ReadLine();
            Contato c3 = new Contato(email);

            if (contatos1.Equals(c3))
            {
                Console.WriteLine(contatos1.pesquisar(c3).ToString());
                retorno = true;
            }
            else
            {
                Console.WriteLine("Email inexistente");
            }

            if (retorno)
            {
                rstring = email;
            }

            Console.ReadKey();
            Console.Clear();

            return rstring;

        }

        public void alterarContato()
        {
            string email = pesquisarContato();

            if (email != "")
            {
                string nome, tipo, numero, pr;
                bool principal = false;
                Data data;
                int dia, mes, ano;
                Telefone telefone;

                Console.WriteLine("Digite o nome do contato: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o dia de nascimento: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o mes de nascimento: ");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o ano de nascimento: ");
                ano = int.Parse(Console.ReadLine());

                Data d1 = new Data();
                d1.setData(dia, mes, ano);

                Console.WriteLine("Digite o tipo de telefone: ");
                tipo = Console.ReadLine();
                Console.WriteLine("Digite o numero de telefone: ");
                numero = Console.ReadLine();
                Console.WriteLine("O número será o principal? (s/n) ");
                pr = Console.ReadLine();

                if (pr == "s")
                {
                    principal = true;
                }
                else
                {
                    principal = false;
                }

                Telefone t1 = new Telefone(tipo, numero, principal);

                Contato c1 = new Contato(email, nome, d1, t1);

                contatos1.alterar(c1);

                Console.WriteLine("Alterado!");

                Console.ReadKey();
                Console.Clear();
            }
        }

        public void removeContato()
        {
            string email = pesquisarContato();

            Contato c5 = new Contato(email);

            if (contatos1.remover(c5))
            {
                Console.WriteLine("Removido!");
            }
            else
            {
                Console.WriteLine("Não removido");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void listarContatos()
        {
            List<Contato> lista = new List<Contato>();
            int counter = 0;

            foreach (Contato c6 in contatos1.agenda)
            {
                lista[counter++] = c6;
            }
        }
    }
}