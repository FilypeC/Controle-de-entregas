using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Controle_de_entregas.Classes;

namespace Controle_de_entregas.Forms
{
    public partial class Busca : Form
    {
        public Busca()
        {
            InitializeComponent();
            var con = new Conectar().GetConnection();

            SqlCommand cmd = new SqlCommand("SELECT Nome_Cliente,Id_Cliente FROM Cliente", con);


            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            NomeClienteBox.DataSource = dt;
            NomeClienteBox.DisplayMember = "Nome_Cliente";
            NomeClienteBox.ValueMember = "Id_Cliente";

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscaBt_Click(object sender, EventArgs e)
        {

            var con = new Conectar().GetConnection();

            var diaInicial = dataInicialDT.Value;
            var diaFinal = dataFinalDT.Value;
            int clienteID = Convert.ToInt32(NomeClienteBox.SelectedValue);



            SqlCommand cmd = new SqlCommand("SELECT Saida, ValorNota, QEntregue, Dia From Viagem WHERE Id_Cliente = @BuscaID AND Dia BETWEEN @DtIni AND @DtFin", con);
            cmd.Parameters.AddWithValue("@BuscaID", clienteID);
            cmd.Parameters.AddWithValue("@DtIni", diaInicial);
            cmd.Parameters.AddWithValue("@DtFin", diaFinal);

            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);


            visualizarBusc.DataSource = dt;
            

            con.Close();

        }

        private void dataInicialDT_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
