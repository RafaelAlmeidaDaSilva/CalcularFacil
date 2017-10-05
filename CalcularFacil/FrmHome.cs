using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFacil
{
    public partial class FrmHome : Form
    {
        String operador;
        //Variaveis De metodos
        String Dificuldade;
        int key;
        public FrmHome()
        {
            InitializeComponent();
        }
        public FrmHome(String Dificuldades, String Operador)
        {
            operador = Operador;
            this.Text = "Calcular - " + Dificuldade;
            this.Dificuldade = Dificuldades;
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            lbOperador.Text = operador;
            GerarNumeros(Dificuldade);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbValorB_Click(object sender, EventArgs e)
        {

        }

        private void lbValorA_Click(object sender, EventArgs e)
        {

        }

        private void txtResultDigitado_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back))
            {
                key = 1;
            }
            else
            {
                key = 0;
            }
        }

        private void txtResultDigitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permite a inserção de números
            if (key != 1)
            {
                if (!(char.IsDigit(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void FrmHome_KeyUp(object sender, KeyEventArgs e)
        {
            //Quando o usuário apertar enter executar ação do botão de entrada
            if (e.KeyCode == Keys.Enter)
            {
                txtResultDigitado_KeyUp(sender, e);
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {

        }

        private void txtResultDigitado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultDigitado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToString(calcularValorCorreto(Convert.ToInt32(lbValorA.Text), Convert.ToInt32(lbValorB.Text), lbOperador.Text)) == txtResultDigitado.Text)
                {
                    lbQtdAcertos.Text = PontuarLabel(lbQtdAcertos.Text);
                    GerarNumeros(Dificuldade);
                    txtResultDigitado.Clear();
                    //acertou
                }
                else
                {
                    lbQtdErros.Text = PontuarLabel(lbQtdErros.Text);
                    GerarNumeros(Dificuldade);
                    txtResultDigitado.Clear();
                    //errou    
                }
            }
        }


        Double calcularValorCorreto(int N1, int N2, String Operador)
        {
            int result;
            switch (Operador)
            {
                case "+":
                    result = Convert.ToInt32(N1 + N2);
                    return Convert.ToDouble(result);
                    break;
                case "-":
                    result = Convert.ToInt32(N1 - N2);
                    return Convert.ToDouble(result);
                    break;
                case "*":
                    result = Convert.ToInt32(N1 * N2);
                    return Convert.ToDouble(result);
                    break;
                case "/":
                    result = Convert.ToInt32(N1 / N2);
                    return Convert.ToDouble(result);
                    break;
                default:
                    return 0.0;
                    MessageBox.Show("Zero");
                    break;
            }

        }

        String PontuarLabel(String UltimoValor)
        {
            int Qtd;
            if (UltimoValor == "...")
            {
                return Convert.ToString(1);
            }
            else
            {
                Qtd = Convert.ToInt32(UltimoValor) + 1;
                return Convert.ToString(Qtd);
            }

        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void GerarNumeros(String nivel)
        {
            Random Rand = new Random();
            switch (nivel)
            {
                case "Facil":
                    lbValorA.Text = Convert.ToString(Rand.Next(0,25));
                    lbValorB.Text = Convert.ToString(Rand.Next(0,25));
                    break;
                case "Medio":
                    lbValorA.Text = Convert.ToString(Rand.Next(26, 51));
                    lbValorB.Text = Convert.ToString(Rand.Next(26, 51));
                    break;
                case "Dificil":
                    lbValorA.Text = Convert.ToString(Rand.Next(52, 77));
                    lbValorB.Text = Convert.ToString(Rand.Next(52, 77));
                    break;
                case "SuperDificil":
                    lbValorA.Text = Convert.ToString(Rand.Next(78, 103));
                    lbValorB.Text = Convert.ToString(Rand.Next(78, 103));
                    break;
                default:
                    break;
            }
        }
    }
}
