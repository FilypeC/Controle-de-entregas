namespace Controle_de_entregas.Forms
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AddCliente = new System.Windows.Forms.Button();
            this.AddViagem = new System.Windows.Forms.Button();
            this.VeriPag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao aplicativo de controle de entregas! Por favor, informe se você quer\r" +
    "\nadicionar um cliente, ver algo de um cliente já cadastrado ou adicionar viagem:" +
    "";
            // 
            // AddCliente
            // 
            this.AddCliente.Location = new System.Drawing.Point(75, 99);
            this.AddCliente.Name = "AddCliente";
            this.AddCliente.Size = new System.Drawing.Size(214, 78);
            this.AddCliente.TabIndex = 1;
            this.AddCliente.Text = "Adicionar cliente";
            this.AddCliente.UseVisualStyleBackColor = true;
            this.AddCliente.Click += new System.EventHandler(this.AddCliente_Click);
            // 
            // AddViagem
            // 
            this.AddViagem.Location = new System.Drawing.Point(305, 99);
            this.AddViagem.Name = "AddViagem";
            this.AddViagem.Size = new System.Drawing.Size(234, 78);
            this.AddViagem.TabIndex = 3;
            this.AddViagem.Text = "Adicionar viagem";
            this.AddViagem.UseVisualStyleBackColor = true;
            this.AddViagem.Click += new System.EventHandler(this.AddViagem_Click);
            // 
            // VeriPag
            // 
            this.VeriPag.Location = new System.Drawing.Point(565, 99);
            this.VeriPag.Name = "VeriPag";
            this.VeriPag.Size = new System.Drawing.Size(234, 78);
            this.VeriPag.TabIndex = 4;
            this.VeriPag.Text = "Busca simples";
            this.VeriPag.UseVisualStyleBackColor = true;
            this.VeriPag.Click += new System.EventHandler(this.VeriPag_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reeitas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VeriPag);
            this.Controls.Add(this.AddViagem);
            this.Controls.Add(this.AddCliente);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "Controle de entregas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCliente;
        private System.Windows.Forms.Button AddViagem;
        private System.Windows.Forms.Button VeriPag;
        private System.Windows.Forms.Button button1;
    }
}

