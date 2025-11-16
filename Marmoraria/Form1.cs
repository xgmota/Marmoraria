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
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1,Port=3306;Database=clientes;User=root;Password=486520"))

            {
                Conexao.Open();
                MessageBox.Show("Ok");
            }
        }
    }
}
