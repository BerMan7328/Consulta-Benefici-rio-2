namespace Consulta_Beneficiário
{
    partial class Init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            this.butConsult = new System.Windows.Forms.Button();
            this.butCadastro = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butConsult
            // 
            this.butConsult.Location = new System.Drawing.Point(27, 69);
            this.butConsult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butConsult.Name = "butConsult";
            this.butConsult.Size = new System.Drawing.Size(240, 121);
            this.butConsult.TabIndex = 1;
            this.butConsult.Text = "Consulta Beneficiário";
            this.butConsult.UseVisualStyleBackColor = true;
            this.butConsult.Click += new System.EventHandler(this.butConsult_Click);
            // 
            // butCadastro
            // 
            this.butCadastro.Location = new System.Drawing.Point(561, 58);
            this.butCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCadastro.Name = "butCadastro";
            this.butCadastro.Size = new System.Drawing.Size(240, 121);
            this.butCadastro.TabIndex = 2;
            this.butCadastro.Text = "Cadastro Beneficiário";
            this.butCadastro.UseVisualStyleBackColor = true;
            this.butCadastro.Click += new System.EventHandler(this.butCadastro_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(316, 367);
            this.butClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(171, 64);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "Fechar";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 460);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butCadastro);
            this.Controls.Add(this.butConsult);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Init";
            this.Text = "Plano Certo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butConsult;
        private System.Windows.Forms.Button butCadastro;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

