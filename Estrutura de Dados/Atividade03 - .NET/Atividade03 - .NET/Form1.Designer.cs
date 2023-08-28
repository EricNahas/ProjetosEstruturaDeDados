namespace Atividade03__.NET
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bnovo = new System.Windows.Forms.Button();
            this.Bsalvar = new System.Windows.Forms.Button();
            this.Bpesquisar = new System.Windows.Forms.Button();
            this.Bremover = new System.Windows.Forms.Button();
            this.Lemail = new System.Windows.Forms.Label();
            this.Lnome = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.Ldt = new System.Windows.Forms.Label();
            this.TBdia = new System.Windows.Forms.TextBox();
            this.TBmes = new System.Windows.Forms.TextBox();
            this.TBano = new System.Windows.Forms.TextBox();
            this.CBtipo = new System.Windows.Forms.ComboBox();
            this.Ltipo = new System.Windows.Forms.Label();
            this.Lnumero = new System.Windows.Forms.Label();
            this.TBnumero = new System.Windows.Forms.TextBox();
            this.CBprincipal = new System.Windows.Forms.CheckBox();
            this.Badicionar = new System.Windows.Forms.Button();
            this.Blistar = new System.Windows.Forms.Button();
            this.TBalerts = new System.Windows.Forms.RichTextBox();
            this.DGVlistar = new System.Windows.Forms.DataGridView();
            this.DGVtelefone = new System.Windows.Forms.DataGridView();
            this.contatosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Bnovo
            // 
            this.Bnovo.Location = new System.Drawing.Point(405, 12);
            this.Bnovo.Name = "Bnovo";
            this.Bnovo.Size = new System.Drawing.Size(75, 23);
            this.Bnovo.TabIndex = 0;
            this.Bnovo.Text = "NOVO";
            this.Bnovo.UseVisualStyleBackColor = true;
            this.Bnovo.Click += new System.EventHandler(this.Bnovo_Click);
            // 
            // Bsalvar
            // 
            this.Bsalvar.Location = new System.Drawing.Point(495, 12);
            this.Bsalvar.Name = "Bsalvar";
            this.Bsalvar.Size = new System.Drawing.Size(75, 23);
            this.Bsalvar.TabIndex = 1;
            this.Bsalvar.Text = "SALVAR";
            this.Bsalvar.UseVisualStyleBackColor = true;
            this.Bsalvar.Click += new System.EventHandler(this.Bsalvar_Click);
            // 
            // Bpesquisar
            // 
            this.Bpesquisar.Location = new System.Drawing.Point(590, 12);
            this.Bpesquisar.Name = "Bpesquisar";
            this.Bpesquisar.Size = new System.Drawing.Size(88, 23);
            this.Bpesquisar.TabIndex = 2;
            this.Bpesquisar.Text = "PESQUISAR";
            this.Bpesquisar.UseVisualStyleBackColor = true;
            this.Bpesquisar.Click += new System.EventHandler(this.Bpesquisar_Click);
            // 
            // Bremover
            // 
            this.Bremover.Location = new System.Drawing.Point(702, 12);
            this.Bremover.Name = "Bremover";
            this.Bremover.Size = new System.Drawing.Size(75, 23);
            this.Bremover.TabIndex = 3;
            this.Bremover.Text = "REMOVER";
            this.Bremover.UseVisualStyleBackColor = true;
            this.Bremover.Click += new System.EventHandler(this.Bremover_Click);
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(120, 72);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(38, 13);
            this.Lemail.TabIndex = 4;
            this.Lemail.Text = "E-mail:";
            // 
            // Lnome
            // 
            this.Lnome.AutoSize = true;
            this.Lnome.Location = new System.Drawing.Point(120, 125);
            this.Lnome.Name = "Lnome";
            this.Lnome.Size = new System.Drawing.Size(41, 13);
            this.Lnome.TabIndex = 5;
            this.Lnome.Text = "Nome: ";
            // 
            // TBemail
            // 
            this.TBemail.Location = new System.Drawing.Point(173, 69);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(100, 20);
            this.TBemail.TabIndex = 6;
            // 
            // TBnome
            // 
            this.TBnome.Location = new System.Drawing.Point(173, 122);
            this.TBnome.Name = "TBnome";
            this.TBnome.Size = new System.Drawing.Size(100, 20);
            this.TBnome.TabIndex = 7;
            // 
            // Ldt
            // 
            this.Ldt.AutoSize = true;
            this.Ldt.Location = new System.Drawing.Point(120, 198);
            this.Ldt.Name = "Ldt";
            this.Ldt.Size = new System.Drawing.Size(110, 13);
            this.Ldt.TabIndex = 8;
            this.Ldt.Text = "Data de Nascimento: ";
            // 
            // TBdia
            // 
            this.TBdia.Location = new System.Drawing.Point(123, 233);
            this.TBdia.Name = "TBdia";
            this.TBdia.Size = new System.Drawing.Size(25, 20);
            this.TBdia.TabIndex = 9;
            // 
            // TBmes
            // 
            this.TBmes.Location = new System.Drawing.Point(154, 233);
            this.TBmes.Name = "TBmes";
            this.TBmes.Size = new System.Drawing.Size(25, 20);
            this.TBmes.TabIndex = 10;
            // 
            // TBano
            // 
            this.TBano.Location = new System.Drawing.Point(185, 233);
            this.TBano.Name = "TBano";
            this.TBano.Size = new System.Drawing.Size(66, 20);
            this.TBano.TabIndex = 11;
            // 
            // CBtipo
            // 
            this.CBtipo.FormattingEnabled = true;
            this.CBtipo.Items.AddRange(new object[] {
            "Móvel",
            "Residencial",
            "Comercial"});
            this.CBtipo.Location = new System.Drawing.Point(484, 233);
            this.CBtipo.Name = "CBtipo";
            this.CBtipo.Size = new System.Drawing.Size(121, 21);
            this.CBtipo.TabIndex = 12;
            // 
            // Ltipo
            // 
            this.Ltipo.AutoSize = true;
            this.Ltipo.Location = new System.Drawing.Point(481, 198);
            this.Ltipo.Name = "Ltipo";
            this.Ltipo.Size = new System.Drawing.Size(34, 13);
            this.Ltipo.TabIndex = 13;
            this.Ltipo.Text = "Tipo: ";
            // 
            // Lnumero
            // 
            this.Lnumero.AutoSize = true;
            this.Lnumero.Location = new System.Drawing.Point(736, 198);
            this.Lnumero.Name = "Lnumero";
            this.Lnumero.Size = new System.Drawing.Size(50, 13);
            this.Lnumero.TabIndex = 14;
            this.Lnumero.Text = "Numero: ";
            // 
            // TBnumero
            // 
            this.TBnumero.Location = new System.Drawing.Point(739, 233);
            this.TBnumero.Name = "TBnumero";
            this.TBnumero.Size = new System.Drawing.Size(100, 20);
            this.TBnumero.TabIndex = 15;
            // 
            // CBprincipal
            // 
            this.CBprincipal.AutoSize = true;
            this.CBprincipal.Location = new System.Drawing.Point(856, 235);
            this.CBprincipal.Name = "CBprincipal";
            this.CBprincipal.Size = new System.Drawing.Size(66, 17);
            this.CBprincipal.TabIndex = 16;
            this.CBprincipal.Text = "Principal";
            this.CBprincipal.UseVisualStyleBackColor = true;
            // 
            // Badicionar
            // 
            this.Badicionar.Location = new System.Drawing.Point(943, 231);
            this.Badicionar.Name = "Badicionar";
            this.Badicionar.Size = new System.Drawing.Size(75, 23);
            this.Badicionar.TabIndex = 17;
            this.Badicionar.Text = "Adicionar";
            this.Badicionar.UseVisualStyleBackColor = true;
            this.Badicionar.Click += new System.EventHandler(this.Badicionar_Click);
            // 
            // Blistar
            // 
            this.Blistar.Location = new System.Drawing.Point(510, 525);
            this.Blistar.Name = "Blistar";
            this.Blistar.Size = new System.Drawing.Size(181, 23);
            this.Blistar.TabIndex = 18;
            this.Blistar.Text = "LISTAR CONTATOS";
            this.Blistar.UseVisualStyleBackColor = true;
            this.Blistar.Click += new System.EventHandler(this.Blistar_Click);
            // 
            // TBalerts
            // 
            this.TBalerts.Location = new System.Drawing.Point(943, 29);
            this.TBalerts.Name = "TBalerts";
            this.TBalerts.Size = new System.Drawing.Size(182, 150);
            this.TBalerts.TabIndex = 20;
            this.TBalerts.Text = "\t\t\t\t\n\n\n\t\t\t\tAVISOS AQUI";
            // 
            // DGVlistar
            // 
            this.DGVlistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlistar.Location = new System.Drawing.Point(439, 318);
            this.DGVlistar.Name = "DGVlistar";
            this.DGVlistar.Size = new System.Drawing.Size(321, 150);
            this.DGVlistar.TabIndex = 21;
            // 
            // DGVtelefone
            // 
            this.DGVtelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtelefone.Location = new System.Drawing.Point(405, 87);
            this.DGVtelefone.Name = "DGVtelefone";
            this.DGVtelefone.Size = new System.Drawing.Size(372, 75);
            this.DGVtelefone.TabIndex = 22;
            // 
            // contatosBindingSource3
            // 
            this.contatosBindingSource3.DataSource = typeof(TP02.Contatos);
            // 
            // contatosBindingSource1
            // 
            this.contatosBindingSource1.DataSource = typeof(TP02.Contatos);
            // 
            // contatosBindingSource
            // 
            this.contatosBindingSource.DataSource = typeof(TP02.Contatos);
            // 
            // contatosBindingSource2
            // 
            this.contatosBindingSource2.DataSource = typeof(TP02.Contatos);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 614);
            this.Controls.Add(this.DGVtelefone);
            this.Controls.Add(this.DGVlistar);
            this.Controls.Add(this.TBalerts);
            this.Controls.Add(this.Blistar);
            this.Controls.Add(this.Badicionar);
            this.Controls.Add(this.CBprincipal);
            this.Controls.Add(this.TBnumero);
            this.Controls.Add(this.Lnumero);
            this.Controls.Add(this.Ltipo);
            this.Controls.Add(this.CBtipo);
            this.Controls.Add(this.TBano);
            this.Controls.Add(this.TBmes);
            this.Controls.Add(this.TBdia);
            this.Controls.Add(this.Ldt);
            this.Controls.Add(this.TBnome);
            this.Controls.Add(this.TBemail);
            this.Controls.Add(this.Lnome);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.Bremover);
            this.Controls.Add(this.Bpesquisar);
            this.Controls.Add(this.Bsalvar);
            this.Controls.Add(this.Bnovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bnovo;
        private System.Windows.Forms.Button Bsalvar;
        private System.Windows.Forms.Button Bpesquisar;
        private System.Windows.Forms.Button Bremover;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label Lnome;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.Label Ldt;
        private System.Windows.Forms.TextBox TBdia;
        private System.Windows.Forms.TextBox TBmes;
        private System.Windows.Forms.TextBox TBano;
        private System.Windows.Forms.ComboBox CBtipo;
        private System.Windows.Forms.Label Ltipo;
        private System.Windows.Forms.Label Lnumero;
        private System.Windows.Forms.TextBox TBnumero;
        private System.Windows.Forms.CheckBox CBprincipal;
        private System.Windows.Forms.Button Badicionar;
        private System.Windows.Forms.Button Blistar;
        private System.Windows.Forms.RichTextBox TBalerts;
        private System.Windows.Forms.BindingSource contatosBindingSource1;
        private System.Windows.Forms.BindingSource contatosBindingSource;
        private System.Windows.Forms.BindingSource contatosBindingSource2;
        private System.Windows.Forms.BindingSource contatosBindingSource3;
        private System.Windows.Forms.DataGridView DGVlistar;
        private System.Windows.Forms.DataGridView DGVtelefone;
    }
}

