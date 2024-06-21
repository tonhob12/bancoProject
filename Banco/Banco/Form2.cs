using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class CriarConta : Form
    {
        banco form1 = new banco();
        public CriarConta()
        {
            InitializeComponent();
        }

        public void inputTitular_TextChanged(object sender, EventArgs e)
        {
          string tituleros = form1.TextoTitular.Text = inputTitular.Text;
        }



        private void criaConta_Click(object sender, EventArgs e)
        {
            if (maior18.Checked)
            {
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não está apto a criar esta conta.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void maior18_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
