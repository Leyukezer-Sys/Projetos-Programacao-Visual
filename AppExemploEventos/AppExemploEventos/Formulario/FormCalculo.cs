using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploEventos.Formulario
{
    public partial class FormCalculo : Form
    {
        FormMensagem msg = new FormMensagem();
        public FormCalculo()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int op;
            double num1 = 0.0, num2 = 0.0, resultado = 0.0;

            num1 = double.Parse(txtValor1.Text);

            num2 = double.Parse(txtValor2.Text);

            if (num2 == 0)
            {
                msg.AlertaMessage("Divisão não é possivel com Zero", "========");
                txtResultado.Text = "Reescreva o valor 2!";
                txtValor2.Clear();
                txtValor2.Focus();
            }
            else
            {

                resultado = num1 / num2;

                txtResultado.Text = resultado.ToString();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();
            txtValor1.Focus();
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && txtValor1.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                msg.AlertaMessage("Digite só números", "");
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValor2.Focus();
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && txtValor1.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                msg.AlertaMessage("Digite só números", "");
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCalcular_Click(sender,e);
            }
        }
    }
}
