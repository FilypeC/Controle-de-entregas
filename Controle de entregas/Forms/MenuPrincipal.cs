using System;
using System.Windows.Forms;

namespace Controle_de_entregas.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void AddCliente_Click(object sender, EventArgs e)
        {
            var cc = new Cadastro();
            cc.Show();
        }

        private void VerCliente_Click(object sender, EventArgs e)
        {
           
        }

        private void AddViagem_Click(object sender, EventArgs e)
        {
            var adc = new Viagem();
            adc.Show();

        }

        private void VeriPag_Click(object sender, EventArgs e)
        {
            var busca = new Busca();
            busca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Receita = new Receitas();
            Receita.Show();
        }
    }
}
