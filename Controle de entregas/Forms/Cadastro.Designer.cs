using System.Windows.Forms;

namespace Controle_de_entregas.Forms
{
    partial class Cadastro
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
            this.NomeCli = new System.Windows.Forms.TextBox();
            this.Pquinzena = new System.Windows.Forms.TextBox();
            this.SQuinzena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SalvarCad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomeCli
            // 
            this.NomeCli.Location = new System.Drawing.Point(69, 138);
            this.NomeCli.Name = "NomeCli";
            this.NomeCli.Size = new System.Drawing.Size(143, 20);
            this.NomeCli.TabIndex = 1;
            this.NomeCli.TextChanged += new System.EventHandler(this.NomeCli_TextChanged);
            // 
            // Pquinzena
            // 
            this.Pquinzena.Location = new System.Drawing.Point(304, 138);
            this.Pquinzena.Name = "Pquinzena";
            this.Pquinzena.Size = new System.Drawing.Size(100, 20);
            this.Pquinzena.TabIndex = 2;
            this.Pquinzena.TextChanged += new System.EventHandler(this.Pquinzena_TextChanged);
            // 
            // SQuinzena
            // 
            this.SQuinzena.Location = new System.Drawing.Point(519, 138);
            this.SQuinzena.Name = "SQuinzena";
            this.SQuinzena.Size = new System.Drawing.Size(100, 20);
            this.SQuinzena.TabIndex = 3;
            this.SQuinzena.TextChanged += new System.EventHandler(this.SQuinzena_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recebimento Primeira Quinzena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Recebimento segunda quinzena";
            // 
            // SalvarCad
            // 
            this.SalvarCad.Location = new System.Drawing.Point(321, 220);
            this.SalvarCad.Name = "SalvarCad";
            this.SalvarCad.Size = new System.Drawing.Size(75, 23);
            this.SalvarCad.TabIndex = 7;
            this.SalvarCad.Text = "Salvar";
            this.SalvarCad.UseVisualStyleBackColor = true;
            this.SalvarCad.Click += new System.EventHandler(this.SalvarCad_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalvarCad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SQuinzena);
            this.Controls.Add(this.Pquinzena);
            this.Controls.Add(this.NomeCli);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NomeCli;
        private TextBox Pquinzena;
        private TextBox SQuinzena;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SalvarCad;
    }
}