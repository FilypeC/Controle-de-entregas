﻿using Controle_de_entregas.Classes;
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

            string connectionString = "Server = (localdb)'\'MSSQLLocalDB; Database = Cliente; User Id = DESKTOP-G1STPAT\filyp; Password = xxxx;";
            SqlConnection sqlConn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (Nome_Cliente,PrimeiraQuinzena,SegundaQuinzena)" + "VALUES('" + NomeCli.Text + "','" + Pquinzena.Text + "', '" + SQuinzena.Text + "')",sqlConn);
            //SqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cliente Salvo!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sqlConn.Close();

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