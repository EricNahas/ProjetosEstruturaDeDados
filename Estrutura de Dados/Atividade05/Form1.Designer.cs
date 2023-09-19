namespace WindowsFormsApp1
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
            this.BGerar = new System.Windows.Forms.Button();
            this.BListar = new System.Windows.Forms.Button();
            this.BAdicionar = new System.Windows.Forms.Button();
            this.BChamar = new System.Windows.Forms.Button();
            this.BListarAtendimento = new System.Windows.Forms.Button();
            this.TGuiche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LGuiche = new System.Windows.Forms.Label();
            this.TListaSenha = new System.Windows.Forms.RichTextBox();
            this.TListaAtendimento = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BGerar
            // 
            this.BGerar.Location = new System.Drawing.Point(71, 42);
            this.BGerar.Name = "BGerar";
            this.BGerar.Size = new System.Drawing.Size(75, 23);
            this.BGerar.TabIndex = 0;
            this.BGerar.Text = "Gerar";
            this.BGerar.UseVisualStyleBackColor = true;
            this.BGerar.Click += new System.EventHandler(this.BGerar_Click);
            // 
            // BListar
            // 
            this.BListar.Location = new System.Drawing.Point(58, 348);
            this.BListar.Name = "BListar";
            this.BListar.Size = new System.Drawing.Size(100, 23);
            this.BListar.TabIndex = 1;
            this.BListar.Text = "Listar Senhas";
            this.BListar.UseVisualStyleBackColor = true;
            this.BListar.Click += new System.EventHandler(this.BListar_Click);
            // 
            // BAdicionar
            // 
            this.BAdicionar.Location = new System.Drawing.Point(322, 187);
            this.BAdicionar.Name = "BAdicionar";
            this.BAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BAdicionar.TabIndex = 2;
            this.BAdicionar.Text = "Adicionar";
            this.BAdicionar.UseVisualStyleBackColor = true;
            this.BAdicionar.Click += new System.EventHandler(this.BAdicionar_Click);
            // 
            // BChamar
            // 
            this.BChamar.Location = new System.Drawing.Point(630, 42);
            this.BChamar.Name = "BChamar";
            this.BChamar.Size = new System.Drawing.Size(75, 23);
            this.BChamar.TabIndex = 3;
            this.BChamar.Text = "Chamar";
            this.BChamar.UseVisualStyleBackColor = true;
            this.BChamar.Click += new System.EventHandler(this.BChamar_Click);
            // 
            // BListarAtendimento
            // 
            this.BListarAtendimento.Location = new System.Drawing.Point(547, 348);
            this.BListarAtendimento.Name = "BListarAtendimento";
            this.BListarAtendimento.Size = new System.Drawing.Size(114, 23);
            this.BListarAtendimento.TabIndex = 4;
            this.BListarAtendimento.Text = "Listar Atendimentos";
            this.BListarAtendimento.UseVisualStyleBackColor = true;
            this.BListarAtendimento.Click += new System.EventHandler(this.BListarAtendimento_Click);
            // 
            // TGuiche
            // 
            this.TGuiche.Location = new System.Drawing.Point(524, 42);
            this.TGuiche.Name = "TGuiche";
            this.TGuiche.Size = new System.Drawing.Size(100, 20);
            this.TGuiche.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guichê: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qtde Guichês";
            // 
            // LGuiche
            // 
            this.LGuiche.AutoSize = true;
            this.LGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LGuiche.Location = new System.Drawing.Point(345, 137);
            this.LGuiche.Name = "LGuiche";
            this.LGuiche.Size = new System.Drawing.Size(29, 31);
            this.LGuiche.TabIndex = 8;
            this.LGuiche.Text = "0";
            this.LGuiche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TListaSenha
            // 
            this.TListaSenha.Location = new System.Drawing.Point(12, 94);
            this.TListaSenha.Name = "TListaSenha";
            this.TListaSenha.Size = new System.Drawing.Size(193, 214);
            this.TListaSenha.TabIndex = 9;
            this.TListaSenha.Text = "";
            // 
            // TListaAtendimento
            // 
            this.TListaAtendimento.Location = new System.Drawing.Point(512, 84);
            this.TListaAtendimento.Name = "TListaAtendimento";
            this.TListaAtendimento.Size = new System.Drawing.Size(193, 214);
            this.TListaAtendimento.TabIndex = 10;
            this.TListaAtendimento.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TListaAtendimento);
            this.Controls.Add(this.TListaSenha);
            this.Controls.Add(this.LGuiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TGuiche);
            this.Controls.Add(this.BListarAtendimento);
            this.Controls.Add(this.BChamar);
            this.Controls.Add(this.BAdicionar);
            this.Controls.Add(this.BListar);
            this.Controls.Add(this.BGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGerar;
        private System.Windows.Forms.Button BListar;
        private System.Windows.Forms.Button BAdicionar;
        private System.Windows.Forms.Button BChamar;
        private System.Windows.Forms.Button BListarAtendimento;
        private System.Windows.Forms.TextBox TGuiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LGuiche;
        private System.Windows.Forms.RichTextBox TListaSenha;
        private System.Windows.Forms.RichTextBox TListaAtendimento;
    }
}

