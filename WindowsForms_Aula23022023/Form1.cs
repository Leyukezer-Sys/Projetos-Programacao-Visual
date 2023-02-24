using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Aula23022023
{
    public partial class Form_Calculadora : Form
    {
        float resultado;
        int valor1, valor2;
        public Form_Calculadora()
        {
            InitializeComponent();
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            lbOperacao.Text = "-";
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 - valor2;
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            lbOperacao.Text = "X";
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 * valor2;
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            if (valor1 < valor2)
            {
                MessageBox.Show("Divisão Inválida\nValor 1 deve ser Maior que Valor 2", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbOperacao.Text = "/";
                resultado = valor1 / valor2;
            }
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            if (lbOperacao.Text == "" || lbOperacao.Text == null)
            {
                MessageBox.Show("Escolha Uma Operação", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            txtResultado.Text = resultado.ToString();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor1.Focus();
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            lbOperacao.Text = "+";
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 + valor2;
        }
    }
}
