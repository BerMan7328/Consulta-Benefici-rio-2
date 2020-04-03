namespace Consulta_Beneficiário
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Btsave = new System.Windows.Forms.Button();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDN = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.TxtCont = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvcad = new System.Windows.Forms.DataGridView();
            this.BtClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.beneficiáriosDataSet = new Consulta_Beneficiário.BeneficiáriosDataSet();
            this.beneficiáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beneficiáriosTableAdapter = new Consulta_Beneficiário.BeneficiáriosDataSetTableAdapters.BeneficiáriosTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btsave
            // 
            this.Btsave.Location = new System.Drawing.Point(24, 316);
            this.Btsave.Name = "Btsave";
            this.Btsave.Size = new System.Drawing.Size(232, 59);
            this.Btsave.TabIndex = 7;
            this.Btsave.Text = "Salvar";
            this.Btsave.UseVisualStyleBackColor = true;
            this.Btsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(15, 159);
            this.TxtTel.Mask = "(00) 00000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(89, 20);
            this.TxtTel.TabIndex = 3;
            this.TxtTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(15, 42);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(396, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NASCIMENTO:";
            // 
            // TxtDN
            // 
            this.TxtDN.Location = new System.Drawing.Point(15, 237);
            this.TxtDN.Mask = "00/00/0000";
            this.TxtDN.Name = "TxtDN";
            this.TxtDN.Size = new System.Drawing.Size(63, 20);
            this.TxtDN.TabIndex = 5;
            this.TxtDN.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ENDEREÇO:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(15, 81);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(396, 20);
            this.txtEnd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "EMAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CONTRATO:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(15, 120);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(199, 20);
            this.TxtMail.TabIndex = 2;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(15, 198);
            this.TxtCpf.Mask = "000.000.000-00";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(89, 20);
            this.TxtCpf.TabIndex = 4;
            // 
            // TxtCont
            // 
            this.TxtCont.Location = new System.Drawing.Point(15, 276);
            this.TxtCont.Mask = "00000";
            this.TxtCont.Name = "TxtCont";
            this.TxtCont.Size = new System.Drawing.Size(39, 20);
            this.TxtCont.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvcad
            // 
            this.dgvcad.AutoGenerateColumns = false;
            this.dgvcad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.contratoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.endereçoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgvcad.DataSource = this.beneficiáriosBindingSource;
            this.dgvcad.Location = new System.Drawing.Point(24, 381);
            this.dgvcad.Name = "dgvcad";
            this.dgvcad.Size = new System.Drawing.Size(666, 85);
            this.dgvcad.TabIndex = 16;
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(274, 472);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(170, 35);
            this.BtClose.TabIndex = 8;
            this.BtClose.Text = "Fechar";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // beneficiáriosDataSet
            // 
            this.beneficiáriosDataSet.DataSetName = "BeneficiáriosDataSet";
            this.beneficiáriosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beneficiáriosBindingSource
            // 
            this.beneficiáriosBindingSource.DataMember = "Beneficiários";
            this.beneficiáriosBindingSource.DataSource = this.beneficiáriosDataSet;
            // 
            // beneficiáriosTableAdapter
            // 
            this.beneficiáriosTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // contratoDataGridViewTextBoxColumn
            // 
            this.contratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato";
            this.contratoDataGridViewTextBoxColumn.HeaderText = "Contrato";
            this.contratoDataGridViewTextBoxColumn.Name = "contratoDataGridViewTextBoxColumn";
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 519);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.dgvcad);
            this.Controls.Add(this.TxtCont);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.Btsave);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Guia de Cadastro de Beneficiário";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btsave;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.MaskedTextBox TxtCont;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvcad;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BeneficiáriosDataSet beneficiáriosDataSet;
        private System.Windows.Forms.BindingSource beneficiáriosBindingSource;
        private BeneficiáriosDataSetTableAdapters.BeneficiáriosTableAdapter beneficiáriosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}