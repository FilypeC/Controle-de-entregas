namespace Controle_de_entregas.Forms
{
    partial class Viagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaClientes = new System.Windows.Forms.ComboBox();
            this.ValorSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantEntregue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ValorNota = new System.Windows.Forms.TextBox();
            this.SavViag = new System.Windows.Forms.Button();
            this.Dia = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ListaClientes
            // 
            this.ListaClientes.FormattingEnabled = true;
            this.ListaClientes.Location = new System.Drawing.Point(20, 197);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(121, 21);
            this.ListaClientes.TabIndex = 0;
            this.ListaClientes.SelectedIndexChanged += new System.EventHandler(this.ListaClientes_SelectedIndexChanged);
            // 
            // ValorSaida
            // 
            this.ValorSaida.Location = new System.Drawing.Point(185, 198);
            this.ValorSaida.Name = "ValorSaida";
            this.ValorSaida.Size = new System.Drawing.Size(100, 20);
            this.ValorSaida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saída";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade entregue";
            // 
            // QuantEntregue
            // 
            this.QuantEntregue.Location = new System.Drawing.Point(522, 197);
            this.QuantEntregue.Name = "QuantEntregue";
            this.QuantEntregue.Size = new System.Drawing.Size(100, 20);
            this.QuantEntregue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insira as infrmações abaixo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor por nota";
            // 
            // ValorNota
            // 
            this.ValorNota.Location = new System.Drawing.Point(343, 198);
            this.ValorNota.Name = "ValorNota";
            this.ValorNota.Size = new System.Drawing.Size(107, 20);
            this.ValorNota.TabIndex = 10;
            // 
            // SavViag
            // 
            this.SavViag.Location = new System.Drawing.Point(357, 267);
            this.SavViag.Name = "SavViag";
            this.SavViag.Size = new System.Drawing.Size(75, 23);
            this.SavViag.TabIndex = 11;
            this.SavViag.Text = "Salvar";
            this.SavViag.UseVisualStyleBackColor = true;
            this.SavViag.Click += new System.EventHandler(this.SavViag_Click);
            // 
            // Dia
            // 
            this.Dia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dia.Location = new System.Drawing.Point(684, 198);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(94, 20);
            this.Dia.TabIndex = 12;
            this.Dia.ValueChanged += new System.EventHandler(this.Dia_ValueChanged);
            // 
            // Viagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.SavViag);
            this.Controls.Add(this.ValorNota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantEntregue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorSaida);
            this.Controls.Add(this.ListaClientes);
            this.Name = "Viagem";
            this.Text = "Adicionar viagem";
            this.Load += new System.EventHandler(this.viagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaClientes;
        private System.Windows.Forms.TextBox ValorSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantEntregue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ValorNota;
        private System.Windows.Forms.Button SavViag;
        private System.Windows.Forms.DateTimePicker Dia;
    }
}