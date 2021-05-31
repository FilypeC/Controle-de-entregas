using Controle_de_entregas.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Controle_de_entregas.Forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SalvarCad_Click(object sender, EventArgs e)
        {
            var Cliente = new Cliente();
            Cliente.Cli = NomeCli.Text;
            Cliente.PagPrimeiraQuinzena = Pquinzena.Text;
            Cliente.PagSegundaQuinzena = SQuinzena.Text;

            var conn = new Conectar().GetConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (Nome_Cliente,Primeira_Quinzena,Segunda_Quinzena)" + "VALUES('" + NomeCli.Text + "','" + Pquinzena.Text + "', '" + SQuinzena.Text + "')",conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Cliente Salvo!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        private void NomeCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pquinzena_TextChanged(object sender, EventArgs e)
        {

        }

        private void SQuinzena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
