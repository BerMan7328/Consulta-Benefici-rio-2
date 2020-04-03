using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Beneficiário
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butLimp_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtDN.Clear();
            txtCPF.Clear();
            txtCont.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void butFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'beneficiáriosDataSet.Pagamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentosTableAdapter.Fill(this.beneficiáriosDataSet.Pagamentos);
            // TODO: esta linha de código carrega dados na tabela 'beneficiáriosDataSet.Beneficiários'. Você pode movê-la ou removê-la conforme necessário.
            this.beneficiáriosTableAdapter.Fill(this.beneficiáriosDataSet.Beneficiários);

        }
    }
}
