using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System;
using System.Data;

namespace TreinoCrud
{
    public partial class Form1 : Form
    {
        public static string connString = "server=localhost;database=sys;user=root;password=root;";
        private static MySqlConnection conn = new MySqlConnection(connString);
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                Debug.WriteLine("Banco Conectado");

                string command = $"INSERT INTO tabela (nome) VALUES ('{textBoxNome.Text}')";

                MySqlCommand mySqlCommand = new MySqlCommand(command, conn);

                Debug.WriteLine(mySqlCommand.ExecuteNonQuery());

                string query = "SELECT * FROM tabela";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);


                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectID_Click(object sender, EventArgs e)
        {
            string command = $"SELECT * FROM tabela WHERE (id = {textBoxID.Text})";
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter(command, conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                Debug.WriteLine("ID não encontrado");
            }
        }

        private void buttonSelectName_Click(object sender, EventArgs e)
        {
            string command = $"SELECT * FROM tabela WHERE (nome = '{textBoxName.Text}')";
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter(command, conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                Debug.WriteLine("Nome não encontrado");
            }
        }

        private void buttonDeleteID_Click(object sender, EventArgs e)
        {
            string command = $"DELETE FROM tabela WHERE (id = {textBoxID.Text})";
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter(command, conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                Debug.WriteLine("ID não encontrado");
            }
        }

        private void buttonDeleteName_Click(object sender, EventArgs e)
        {
            string command = $"DELETE FROM tabela WHERE (nome = '{textBoxName.Text}')";
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter(command, conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                Debug.WriteLine("Nome não encontrado");
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tabela";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);


            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
