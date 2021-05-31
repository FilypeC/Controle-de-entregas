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
    {
        public Viagem()
        {
            InitializeComponent();
            
            var con = new Conectar().GetConnection();

            SqlCommand cmd = new SqlCommand("SELECT Nome_Cliente,Id_Cliente FROM Cliente", con);


            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            ListaClientes.DataSource = dt;
            ListaClientes.DisplayMember = "Nome_Cliente";
            ListaClientes.ValueMember = "Id_Cliente";
          //int id_selecionado = (int)ListaClientes.SelectedValue;

            con.Close();
        }

        private void viagem_Load(object sender, EventArgs e)
        {

        }

            private void SavViag_Click(object sender, EventArgs e)
        {
            try
            {
                var Viagem = new Entrega();
                Viagem.Cli = Convert.ToInt32((int)ListaClientes.SelectedValue);
                Viagem.Dia = Dia.Value;
                Viagem.Nota = Convert.ToDouble(ValorNota.Text);
                Viagem.Quantidade = Convert.ToInt32(QuantEntregue.Text);
                Viagem.Saida = Convert.ToDouble(ValorSaida.Text);

                var con = new Conectar().GetConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO Viagem (Id_Cliente,Saida,ValorNota,QEntregue,Dia) VALUES(@Id_Cliente,@Saida,@ValorNota,@QEntregue,@Dia)", con);
                cmd.Parameters.AddWithValue("@Id_Cliente", Viagem.Cli);
                cmd.Parameters.AddWithValue("@Saida", Viagem.Saida);
                cmd.Parameters.AddWithValue("@ValorNota", Viagem.Nota);
                cmd.Parameters.AddWithValue("@QEntregue", Viagem.Quantidade);
                cmd.Parameters.AddWithValue("@Dia", Viagem.Dia);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Salvo!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Dia_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
