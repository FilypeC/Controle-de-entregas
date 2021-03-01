using Controle_de_entregas.Classes;
using Controle_de_entregas.Infraestrura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Controle_de_entregas.Forms
{
    public partial class Viagem : Form
    {/*
        public Viagem()
        {
            *InitializeComponent();
              var itensdao = new ItensDAO();
              var dados = itensdao.ListarItens();
              ListaClientes.DisplayMember = "descricao";
              ListaClientes.ValueMember = "codigo";
              ListaClientes.DataSource = dados;
              ListaClientes.SelectedIndex = -1;

          }
            */
            private void viagem_Load(object sender, EventArgs e)
        {

        }

        private void SavViag_Click(object sender, EventArgs e)
        {
            var Viagem = new Entrega();
            Viagem.Cli = ListaClientes.Text;
            Viagem.Dia = Convert.ToDateTime(Dia.Text);
            Viagem.Nota = Convert.ToDouble(ValorNota.Text);
            Viagem.Quantidade = Convert.ToInt32(QuantEntregue.Text);
            Viagem.Saida = Convert.ToDouble(ValorSaida.Text);
        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server = (localdb)'\'MSSQLLocalDB; Database = Cliente; User Id = DESKTOP-G1STPAT\filyp; Password = xxxx;";
            SqlConnection sqlConn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT Nome_Cliente FROM Cliente", sqlConn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListaClientes.Items.Add(dr[0]);

            }
        }
    }
}
