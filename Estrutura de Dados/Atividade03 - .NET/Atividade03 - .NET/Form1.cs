using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP02;

namespace Atividade03__.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Controller controle = new Controller();
        Contatos contatos1 = new Contatos();

        private void Bnovo_Click(object sender, EventArgs e)
        {
            TBdia.Text = ""; TBmes.Text = ""; TBano.Text = ""; TBemail.Text = ""; TBnome.Text = ""; 
            TBnumero.Text = ""; CBtipo.Text = ""; TBalerts.Text = "";
            DGVtelefone.DataSource = null;
            DGVlistar.DataSource= null;
        }

        private void Bsalvar_Click(object sender, EventArgs e)
        {
            string nome, email, tipo, numero;
            int dia, mes, ano;
            
            nome = TBnome.Text;
            email = TBemail.Text;
            dia = int.Parse(TBdia.Text);
            mes = int.Parse(TBmes.Text);
            ano = int.Parse(TBano.Text);

            Data d1 = new Data();
            d1.setData(dia, mes, ano);

            tipo = CBtipo.Text;
            numero = TBnumero.Text;

            Telefone t1 = new Telefone(tipo, numero);
            Contato c1 = new Contato(email, nome, d1, t1);

            if (contatos1.adicionar(c1))
            {
                TBalerts.Text = "Contato adicionado!";
            }
            else
            {
                TBalerts.Text = "Contato não adicionado";
            }
        }

        private void Bremover_Click(object sender, EventArgs e)
        {
            Contato remove = new Contato(TBemail.Text);
            int x = contatos1.agenda.IndexOf(contatos1.pesquisar(remove));

            if (x != -1)
            {
                contatos1.agenda.Remove(contatos1.pesquisar(remove));
                TBalerts.Text = "Removido!";
            }
            else
            {
                TBalerts.Text = "Não foi possível remover";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bpesquisar_Click(object sender, EventArgs e)
        {
            string email;
            email = TBemail.Text;
            Contato c3 = new Contato(email);

            if (contatos1.Equals(c3))
            {

                List<Contato> lista = new List<Contato>();

                foreach (Contato c6 in contatos1.agenda)
                {
                    if (email == c6.Email)
                    {
                        lista.Add(c6);
                    }
                }

                DGVlistar.DataSource = null;
                DGVlistar.DataSource = lista;
                DGVlistar.Refresh();

                TBalerts.Text = "Informações na tela!";
            }
            else
            {
               TBalerts.Text = "Email inexistente";
               DGVlistar.DataSource = null;
            }

        }

        private void Badicionar_Click(object sender, EventArgs e)
        {
            string email, tipo, numero;
            bool principal;
            email = TBemail.Text;

            Contato c2 = new Contato(email);

            if (contatos1.pesquisar(c2).getEmail() != "")
            {
                tipo = CBtipo.Text;
                numero = TBnumero.Text;
                principal = CBprincipal.Checked;

                if (tipo == "" || numero == "")
                {
                    TBalerts.Text = "Não foi inserido! Digite corretamente numero e tipo";
                }
                else
                {
                    Telefone t2 = new Telefone(tipo, numero, principal);

                    int x = contatos1.agenda.IndexOf(contatos1.pesquisar(c2));
                    contatos1.agenda[x].adicionarTelefone(t2);

                    TBalerts.Text = "Inserido!";

                    DGVtelefone.DataSource = null;
                    List<Telefone> lista = new List<Telefone>();

                    foreach (Telefone t in contatos1.agenda[x].Telefones)
                    {
                        lista.Add(t);
                    }

                    DGVtelefone.DataSource = lista;
                    DGVtelefone.Refresh();
                }
            }
            else
            {
                TBalerts.Text = "E-mail não existe";
                DGVtelefone.DataSource = null;
            }
        }

        private void Blistar_Click(object sender, EventArgs e)
        {
            List<Contato> lista = new List<Contato>();

            foreach (Contato c6 in contatos1.agenda)
            {
                lista.Add(c6);
            }
            
            DGVlistar.DataSource = null;
            DGVlistar.DataSource = lista;
            DGVlistar.Refresh();
        }

    }
}
