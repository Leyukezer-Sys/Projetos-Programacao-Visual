using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAula02032023
{
    public partial class Form_CalculadoraDesconto : Form
    {
        public Form_CalculadoraDesconto()
        {
            InitializeComponent();
        }

        private void MessageAlerta(String Message)
        {
            MessageBox.Show(Message, "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valorCompra, PorcDesconto, total;
            if (txtValorCompra.Text == "" || txtValorCompra.Text.Equals(null))
            {
                MessageAlerta("Insira um Valor da Compra");
                txtValorCompra.Focus();
            }
            else if (txtDesconto.Text == "" || txtDesconto.Text.Equals(null))
            {
                lbErro.Text = "Valor Final foi Calculado sem Desconto!";
                lbErro.Visible = true;
                valorCompra = Convert.ToDouble(txtValorCompra.Text);
                txtValorComDesconto.Text = valorCompra.ToString("C");
            }
            else
            {
                valorCompra = Convert.ToDouble(txtValorCompra.Text);
                PorcDesconto = Convert.ToDouble(txtDesconto.Text) / 100;

                total = valorCompra - (valorCompra * PorcDesconto);

                txtValorComDesconto.Text = total.ToString("C");
            }
        }

        private void btNovoCalculo_Click(object sender, EventArgs e)
        {
            txtDesconto.Clear();
            txtValorComDesconto.Clear();
            txtValorCompra.Clear();
            txtValorCompra.Focus();
            lbErro.Text = null;
            lbErro.Visible = false;
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageAlerta("este campo aceita somente numero e virgula");
                txtValorCompra.Focus();
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageAlerta("este campo aceita somente numero e virgula");
                txtDesconto.Focus();
            }
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btCalcular_Click(sender,e);
        }

        private void txtValorCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtDesconto.Focus();
        }

        private void txtValorComDesconto_MouseHover(object sender, EventArgs e)
        {
            txtValorComDesconto.Enabled = false;
        }

        private void txtValorComDesconto_MouseLeave(object sender, EventArgs e)
        {
            txtValorComDesconto.Enabled = true;
        }
    }
}