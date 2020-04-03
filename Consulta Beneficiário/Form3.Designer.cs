namespace Consulta_Beneficiário
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.butLimp = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butFechar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCont = new System.Windows.Forms.MaskedTextBox();
            this.txtDN = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.beneficiáriosDataSet = new Consulta_Beneficiário.BeneficiáriosDataSet();
            this.beneficiáriosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beneficiáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beneficiáriosTableAdapter = new Consulta_Beneficiário.BeneficiáriosDataSetTableAdapters.BeneficiáriosTableAdapter();
            this.pagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentosTableAdapter = new Consulta_Beneficiário.BeneficiáriosDataSetTableAdapters.PagamentosTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // butLimp
            // 
            this.butLimp.Location = new System.Drawing.Point(288, 38);
            this.butLimp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butLimp.Name = "butLimp";
            this.butLimp.Size = new System.Drawing.Size(131, 34);
            this.butLimp.TabIndex = 5;
            this.butLimp.Text = "Limpar";
            this.butLimp.UseVisualStyleBackColor = true;
            this.butLimp.Click += new System.EventHandler(this.butLimp_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 44);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(259, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(20, 92);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(111, 22);
            this.txtCPF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONTRATO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "NASCIMENTO:";
            // 
            // butFechar
            // 
            this.butFechar.Location = new System.Drawing.Point(288, 496);
            this.butFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butFechar.Name = "butFechar";
            this.butFechar.Size = new System.Drawing.Size(211, 43);
            this.butFechar.TabIndex = 6;
            this.butFechar.Text = "Fechar";
            this.butFechar.UseVisualStyleBackColor = true;
            this.butFechar.Click += new System.EventHandler(this.butFechar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 239);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(20, 188);
            this.txtCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCont.Mask = "00000";
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(51, 22);
            this.txtCont.TabIndex = 3;
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(20, 140);
            this.txtDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDN.Mask = "00/00/0000";
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(88, 22);
            this.txtDN.TabIndex = 2;
            this.txtDN.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.contratoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.endereçoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.beneficiáriosBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(749, 185);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // beneficiáriosDataSet
            // 
            this.beneficiáriosDataSet.DataSetName = "BeneficiáriosDataSet";
            this.beneficiáriosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beneficiáriosDataSetBindingSource
            // 
            this.beneficiáriosDataSetBindingSource.DataSource = this.beneficiáriosDataSet;
            this.beneficiáriosDataSetBindingSource.Position = 0;
            // 
            // beneficiáriosBindingSource
            // 
            this.beneficiáriosBindingSource.DataMember = "Beneficiários";
            this.beneficiáriosBindingSource.DataSource = this.beneficiáriosDataSetBindingSource;
            // 
            // beneficiáriosTableAdapter
            // 
            this.beneficiáriosTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentosBindingSource
            // 
            this.pagamentosBindingSource.DataMember = "Pagamentos";
            this.pagamentosBindingSource.DataSource = this.beneficiáriosDataSetBindingSource;
            // 
            // pagamentosTableAdapter
            // 
            this.pagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Width = 125;
            // 
            // contratoDataGridViewTextBoxColumn
            // 
            this.contratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato";
            this.contratoDataGridViewTextBoxColumn.HeaderText = "Contrato";
            this.contratoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contratoDataGridViewTextBoxColumn.Name = "contratoDataGridViewTextBoxColumn";
            this.contratoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contratoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nascimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEPDataGridViewTextBoxColumn.Width = 125;
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            this.endereçoDataGridViewTextBoxColumn.ReadOnly = true;
            this.endereçoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butFechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.butLimp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Guia de Consulta de Beneficiário";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiáriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLimp;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butFechar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txtCont;
        private System.Windows.Forms.MaskedTextBox txtDN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource beneficiáriosDataSetBindingSource;
        private BeneficiáriosDataSet beneficiáriosDataSet;
        private System.Windows.Forms.BindingSource beneficiáriosBindingSource;
        private BeneficiáriosDataSetTableAdapters.BeneficiáriosTableAdapter beneficiáriosTableAdapter;
        private System.Windows.Forms.BindingSource pagamentosBindingSource;
        private BeneficiáriosDataSetTableAdapters.PagamentosTableAdapter pagamentosTableAdapter;
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