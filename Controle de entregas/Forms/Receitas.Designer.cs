namespace Controle_de_entregas.Forms
{
    partial class Receitas
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
            this.ListCli = new System.Windows.Forms.ComboBox();
            this.LCli = new System.Windows.Forms.Label();
            this.LQuinzena = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BBusca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListCli
            // 
            this.ListCli.FormattingEnabled = true;
            this.ListCli.Location = new System.Drawing.Point(12, 27);
            this.ListCli.Name = "ListCli";
            this.ListCli.Size = new System.Drawing.Size(121, 21);
            this.ListCli.TabIndex = 0;
            // 
            // LCli
            // 
            this.LCli.AutoSize = true;
            this.LCli.Location = new System.Drawing.Point(48, 9);
            this.LCli.Name = "LCli";
            this.LCli.Size = new System.Drawing.Size(39, 13);
            this.LCli.TabIndex = 1;
            this.LCli.Text = "Cliente";
            this.LCli.Click += new System.EventHandler(this.LCli_Click);
            // 
            // LQuinzena
            // 
            this.LQuinzena.AutoSize = true;
            this.LQuinzena.Location = new System.Drawing.Point(228, 9);
            this.LQuinzena.Name = "LQuinzena";
            this.LQuinzena.Size = new System.Drawing.Size(52, 13);
            this.LQuinzena.TabIndex = 3;
            this.LQuinzena.Text = "Quinzena";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // BBusca
            // 
            this.BBusca.Location = new System.Drawing.Point(390, 24);
            this.BBusca.Name = "BBusca";
            this.BBusca.Size = new System.Drawing.Size(75, 23);
            this.BBusca.TabIndex = 4;
            this.BBusca.Text = "Busca";
            this.BBusca.UseVisualStyleBackColor = true;
            // 
            // Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BBusca);
            this.Controls.Add(this.LQuinzena);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LCli);
            this.Controls.Add(this.ListCli);
            this.Name = "Receitas";
            this.Text = "Receitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListCli;
        private System.Windows.Forms.Label LCli;
        private System.Windows.Forms.Label LQuinzena;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BBusca;
    }
}