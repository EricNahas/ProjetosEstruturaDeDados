using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
            LGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void BAdicionar_Click(object sender, EventArgs e)
        {
            Guiche guiche = new Guiche(guiches.ListaGuiches.Count);
            guiches.ListaGuiches.Add(guiche);
            LGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void BGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void BListar_Click(object sender, EventArgs e)
        {
            TListaSenha.Text = "";
            foreach (Senha s in senhas.FilaSenhas) 
            {
                TListaSenha.Text += s.dadosParciais() + "\n";
            }
        }

        private void BChamar_Click(object sender, EventArgs e)
        {
            foreach (Guiche g in guiches.ListaGuiches)
            {
                if (int.Parse(TGuiche.Text) == g.Id)
                {
                    g.chamar(senhas.FilaSenhas);
                }
            }
        }

        private void BListarAtendimento_Click(object sender, EventArgs e)
        {
            TListaAtendimento.Text = "";

            foreach (Guiche g in guiches.ListaGuiches)
            {
                if (int.Parse(TGuiche.Text) == g.Id)
                {
                    foreach (Senha s in g.Atendimento)
                    {
                        TListaAtendimento.Text += s.dadosCompletos() + "\n";
                    }
                }
            }
        }
    }
}
