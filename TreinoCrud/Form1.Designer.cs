namespace TreinoCrud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEnviar = new Button();
            LabelNome = new Label();
            textBoxNome = new TextBox();
            dataGridView1 = new DataGridView();
            buttonSelectID = new Button();
            buttonSelectName = new Button();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            buttonDeleteID = new Button();
            buttonDeleteName = new Button();
            buttonSelectAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(588, 194);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 0;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(398, 194);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(43, 15);
            LabelNome.TabIndex = 1;
            LabelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(447, 191);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 2;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(423, 345);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 3;
            // 
            // buttonSelectID
            // 
            buttonSelectID.Location = new Point(326, 443);
            buttonSelectID.Name = "buttonSelectID";
            buttonSelectID.Size = new Size(91, 23);
            buttonSelectID.TabIndex = 4;
            buttonSelectID.Text = "Selecionar ID";
            buttonSelectID.UseVisualStyleBackColor = true;
            buttonSelectID.Click += buttonSelectID_Click;
            // 
            // buttonSelectName
            // 
            buttonSelectName.Location = new Point(669, 443);
            buttonSelectName.Name = "buttonSelectName";
            buttonSelectName.Size = new Size(108, 23);
            buttonSelectName.TabIndex = 5;
            buttonSelectName.Text = "Selecionar Nome";
            buttonSelectName.UseVisualStyleBackColor = true;
            buttonSelectName.Click += buttonSelectName_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(326, 472);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(91, 23);
            textBoxID.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(669, 472);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(108, 23);
            textBoxName.TabIndex = 7;
            // 
            // buttonDeleteID
            // 
            buttonDeleteID.Location = new Point(307, 345);
            buttonDeleteID.Name = "buttonDeleteID";
            buttonDeleteID.Size = new Size(110, 23);
            buttonDeleteID.TabIndex = 8;
            buttonDeleteID.Text = "Apagar pelo ID";
            buttonDeleteID.UseVisualStyleBackColor = true;
            buttonDeleteID.Click += buttonDeleteID_Click;
            // 
            // buttonDeleteName
            // 
            buttonDeleteName.Location = new Point(669, 345);
            buttonDeleteName.Name = "buttonDeleteName";
            buttonDeleteName.Size = new Size(123, 23);
            buttonDeleteName.TabIndex = 9;
            buttonDeleteName.Text = "Apagar pelo Nome";
            buttonDeleteName.UseVisualStyleBackColor = true;
            buttonDeleteName.Click += buttonDeleteName_Click;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Location = new Point(492, 316);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(110, 23);
            buttonSelectAll.TabIndex = 10;
            buttonSelectAll.Text = "Selecionar Tudo";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 543);
            Controls.Add(buttonSelectAll);
            Controls.Add(buttonDeleteName);
            Controls.Add(buttonDeleteID);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(buttonSelectName);
            Controls.Add(buttonSelectID);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxNome);
            Controls.Add(LabelNome);
            Controls.Add(buttonEnviar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnviar;
        private Label LabelNome;
        private TextBox textBoxNome;
        private DataGridView dataGridView1;
        private Button buttonSelectID;
        private Button buttonSelectName;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private Button buttonDeleteID;
        private Button buttonDeleteName;
        private Button buttonSelectAll;
    }
}
