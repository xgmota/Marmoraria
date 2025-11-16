using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marmoraria
{
    public partial class FrmCadastroClientes : Form
    {
        public object Conexao { get; private set; }

        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1,Port=3306;Database=banco_de_dados_marmoraria;User=root;Password=486520"))

            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes (nome, telefone, documento, rua, numero, bairro, cidade, observacoes) VALUES (@nome, @telefone, @documento, @rua, @numero, @bairro, @cidade, @observacoes)";

                    int num;
                    if (textBoxNumero.Text == "")
                    {
                        num = 0;
                    } else
                    {
                        num =int.Parse(textBoxNumero.Text);
                    }
                    
                    cmd.Parameters.AddWithValue("@nome", textBoxNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", textBoxTelefone.Text);
                    cmd.Parameters.AddWithValue("@documento", textBoxDocumento.Text);
                    cmd.Parameters.AddWithValue("@rua", num);
                    cmd.Parameters.AddWithValue("@numero", textBoxNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", textBoxBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", textBoxCidade.Text);
                    cmd.Parameters.AddWithValue("@observacoes", textBoxObs.Text);

                    cmd.ExecuteNonQuery();
                }
                // MessageBox.Show("Ok");
            }
        }
    }
}
