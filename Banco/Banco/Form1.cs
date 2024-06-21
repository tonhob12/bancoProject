using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Banco
{
    public partial class banco : Form
    {
        private Conta c;
        public banco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CriarConta form2 = new CriarConta();
            this.c = new Conta();
            Random number = new Random();
            int numberInt = number.Next(1, 10);
            c.Numero = numberInt;
            var tituleros = TextoTitular.Text;
            Cliente cliente = new Cliente(tituleros);
            TextoNumero.Text = Convert.ToString(c.Numero);
            TextoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = TextoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperacao);
            TextoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso! =)");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.c.Saldo >= 1)
            {
                string valorDigitado = TextoValor.Text;
                double valorOperacao = Convert.ToDouble(valorDigitado);
                c.Saca(valorOperacao);
                TextoSaldo.Text = Convert.ToString(this.c.Saldo);
                MessageBox.Show("Sucesso! =)");
            }
            else
            {
                MessageBox.Show("Sem dinheiro suficiente. =(");
            }

        }
    }
}
