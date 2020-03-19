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
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butConsult_Click(object sender, EventArgs e)
        {
            Form3 FormCadastro = new Form3();
            FormCadastro.ShowDialog();
        }

        private void butCadastro_Click(object sender, EventArgs e)
        {
            Form2 FormConsult = new Form2();
            FormConsult.ShowDialog();
        }
    }
}
