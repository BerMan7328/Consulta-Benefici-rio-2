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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Beneficiario = new Beneficiario();
           
            List<Beneficiario> ListBeneficiario = new List<Beneficiario>();
            ListBeneficiario.Add(RetornarBeneficiario(Beneficiario));

            dgvcad.DataSource = ListBeneficiario;
        }

        private Beneficiario RetornarBeneficiario(Beneficiario Beneficiario)
        {

            if (TxtNome.Text != string.Empty)
            {
                Beneficiario.TxtNome = TxtNome.Text;
            }
            else
            {
                MessageBox.Show("Gentileza preencher o Campo Nome.");
            }

            if (txtEnd.Text != string.Empty)
            {
                Beneficiario.TxtEnd = txtEnd.Text;
            }
            else
            {
                MessageBox.Show("Gentileza preencher o Campo Endereço.");
            }

            if (TxtMail.Text != string.Empty)
            {
                Beneficiario.TxtMail = TxtMail.Text;
            }
            else
            {
                MessageBox.Show("Gentileza preencher o Campo E-mail.");
            }

            if (TxtTel.Text != string.Empty)
            {
                Beneficiario.TxtTel = TxtTel.Text;
            }
            else
            {
                MessageBox.Show("Gentileza preencher o Campo Telefone.");
            }

            if (TxtCpf.Text != string.Empty)
            {
                Beneficiario.TxtCpf = TxtCpf.Text;
            }
            else
            {
                MessageBox.Show("Gentileza preencher o Campo CPF.");
            }

            if (TxtDN.Text != string.Empty)
            {
                Beneficiario.TxtDN = TxtDN.Text;
            }
            else
            {
                MessageBox.Show("Gentileza preencher o Campo Nascimento.");
            }

            if (TxtCont.Text != string.Empty)
            {
                Beneficiario.TxtCont = TxtCont.Text;
            }
            else
            {
                MessageBox.Show("Gentileza preencher o Campo Contrato.");
            }
            return Beneficiario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'beneficiáriosDataSet.Beneficiários'. Você pode movê-la ou removê-la conforme necessário.
            this.beneficiáriosTableAdapter.Fill(this.beneficiáriosDataSet.Beneficiários);

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
