namespace Controle_de_entregas.Forms
{
    partial class Busca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeClienteBox = new System.Windows.Forms.ComboBox();
            this.dataInicialDT = new System.Windows.Forms.DateTimePicker();
            this.dataFinalDT = new System.Windows.Forms.DateTimePicker();
            this.buscaBt = new System.Windows.Forms.Button();
            this.visualizarBusc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.visualizarBusc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Infome os dados pedidos abaixo:";
            // 
            // NomeClienteBox
            // 
            this.NomeClienteBox.FormattingEnabled = true;
            this.NomeClienteBox.Location = new System.Drawing.Point(101, 124);
            this.NomeClienteBox.Name = "NomeClienteBox";
            this.NomeClienteBox.Size = new System.Drawing.Size(121, 21);
            this.NomeClienteBox.TabIndex = 7;
            this.NomeClienteBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataInicialDT
            // 
            this.dataInicialDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicialDT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataInicialDT.Location = new System.Drawing.Point(324, 124);
            this.dataInicialDT.Name = "dataInicialDT";
            this.dataInicialDT.Size = new System.Drawing.Size(93, 20);
            this.dataInicialDT.TabIndex = 8;
            this.dataInicialDT.ValueChanged += new System.EventHandler(this.dataInicialDT_ValueChanged);
            // 
            // dataFinalDT
            // 
            this.dataFinalDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinalDT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataFinalDT.Location = new System.Drawing.Point(509, 125);
            this.dataFinalDT.Name = "dataFinalDT";
            this.dataFinalDT.Size = new System.Drawing.Size(93, 20);
            this.dataFinalDT.TabIndex = 9;
            // 
            // buscaBt
            // 
            this.buscaBt.Location = new System.Drawing.Point(662, 126);
            this.buscaBt.Name = "buscaBt";
            this.buscaBt.Size = new System.Drawing.Size(75, 23);
            this.buscaBt.TabIndex = 10;
            this.buscaBt.Text = "Buscar!";
            this.buscaBt.UseVisualStyleBackColor = true;
            this.buscaBt.Click += new System.EventHandler(this.buscaBt_Click);
            // 
            // visualizarBusc
            // 
            this.visualizarBusc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualizarBusc.Location = new System.Drawing.Point(278, 197);
            this.visualizarBusc.Name = "visualizarBusc";
            this.visualizarBusc.Size = new System.Drawing.Size(240, 150);
            this.visualizarBusc.TabIndex = 11;
            // 
            // Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visualizarBusc);
            this.Controls.Add(this.buscaBt);
            this.Controls.Add(this.dataFinalDT);
            this.Controls.Add(this.dataInicialDT);
            this.Controls.Add(this.NomeClienteBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Busca";
            this.Text = "Busca de ganhos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualizarBusc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NomeClienteBox;
        private System.Windows.Forms.DateTimePicker dataInicialDT;
        private System.Windows.Forms.DateTimePicker dataFinalDT;
        private System.Windows.Forms.Button buscaBt;
        private System.Windows.Forms.DataGridView visualizarBusc;
    }
}