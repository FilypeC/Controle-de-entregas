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
using Controle_de_entregas.Classes;

namespace Controle_de_entregas.Forms
{
    public partial class Receitas : Form
    {
        public Receitas()
        {
            InitializeComponent();

            //lista de clientes
            var con = new Conectar().GetConnection();

            SqlCommand cmd = new SqlCommand("SELECT Nome_Cliente,Id_Cliente FROM Cliente", con);


            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            ListCli.DataSource = dt;
            ListCli.DisplayMember = "Nome_Cliente";
            ListCli.ValueMember = "Id_Cliente";

            con.Close();

            //selecionar relatorio
           
            comboBox1.Items.Add("Selecione");
            comboBox1.Items.Add("Mensal");
            comboBox1.Items.Add("Quinzenal");
            comboBox1.Items.Add("anual");
        }

        private void LCli_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LQuinzena_Click(object sender, EventArgs e)
        {

        }

        private void Receitas_Load(object sender, EventArgs e)
        {

        }

        private void BBusca_Click(object sender, EventArgs e)
        {
            String relatorio = Convert.ToString(comboBox1.SelectedItem);
            
            if (relatorio == "Selecione")
            {
                MessageBox.Show("Selecione o relatorio correto!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (relatorio == "Mensal" )
            {
                var con = new Conectar().GetConnection();

                
                var dia = dataDT.Value;

                SqlCommand cmd = new SqlCommand("SELECT Nome_Cliente,Cliente.Id_Cliente, DATEPART(Year, @DtIni),DATEPART(MONTH, @DtIni), SUM( (ValorNota*QEntregue)+Saida) as TotalMes from Viagem INNER JOIN Cliente on Viagem.Id_Cliente = Cliente.Id_Cliente Group by Nome_Cliente, Cliente.Id_Cliente, DATEPART(Year, Dia), DATEPART(MONTH, Dia); ", con);
                cmd.Parameters.AddWithValue("@DtIni", dia);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);


                dataGridView1.DataSource = dt;


                con.Close();




            }
            else if (relatorio == "Quinzenal")
            {
                var con = new Conectar().GetConnection();


                var dia = dataDT.Value;

                SqlCommand cmd = new SqlCommand("SELECT Nome_Cliente,Cliente.Id_Cliente, DATEPART(Year, @DtIni),DATEPART(MONTH, @DtIni), FLOOR(LOG(Datepart(DAY,Dia))/LOG(16))+1 AS QUINZENA, SUM( (ValorNota*QEntregue)+Saida) as TotalQUinzena from Viagem INNER JOIN Cliente on Viagem.Id_Cliente = Cliente.Id_Cliente Group by Nome_Cliente, Cliente.Id_Cliente, DATEPART(Year, Dia), DATEPART(MONTH, Dia), FLOOR(LOG(Datepart(DAY, Dia)) / LOG(16))", con);
                cmd.Parameters.AddWithValue("@DtIni", dia);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);


                dataGridView1.DataSource = dt;


                con.Close();
            }
            else if (relatorio == "anual")
            {
                var con = new Conectar().GetConnection();


                var dia = dataDT.Value;

                SqlCommand cmd = new SqlCommand("SELECT Nome_Cliente,Cliente.Id_Cliente, DATEPART(Year, @DtIni), SUM( (ValorNota*QEntregue)+Saida) as TotalAno from Viagem INNER JOIN Cliente on Viagem.Id_Cliente = Cliente.Id_Cliente Group by Nome_Cliente, Cliente.Id_Cliente, DATEPART(Year, Dia), DATEPART(MONTH, Dia); ", con);
                cmd.Parameters.AddWithValue("@DtIni", dia);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);


                dataGridView1.DataSource = dt;


                con.Close();
            }
        }
    }
}
