using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadoraDiversa.Formularios
{
    public partial class FormCalculadoraDesconto : Form
    {
        double porcentagem= 0.0;
        public FormCalculadoraDesconto()
        {
            InitializeComponent();
            txtDesconto.ReadOnly = true;
            txtTotalDescoto.ReadOnly = true;
            lbDesconto.Visible = false;
            cbOpcao.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbOpcao.SelectedIndex = -1;
            cbOpcao.Focus();
            txtDesconto.Clear();
            txtTotalDescoto.Clear();
            txtValorCompra.Clear();
            lbDesconto.Visible = false;
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op = cbOpcao.SelectedIndex;
            switch (op)
            {
                case 0:
                    lbDesconto.Text = "Cliente do tipo COMUM Recebe 3% de Desconto";
                    porcentagem = 0.03;
                    lbDesconto.Visible = true;
                    txtDesconto.Text = "REALIZE O DESCONTO!";
                    txtValorCompra.Focus();
                    break;
                case 1:
                    lbDesconto.Text = "Cliente do tipo ESPECIAL Recebe 5% de Desconto";
                    porcentagem = 0.05;
                    lbDesconto.Visible = true;
                    txtDesconto.Text = "REALIZE O DESCONTO!";
                    txtValorCompra.Focus();
                    break;
                case 2:
                    lbDesconto.Text = "Cliente do tipo VIP Recebe 10% de Desconto";
                    porcentagem = 0.10;
                    lbDesconto.Visible = true;
                    txtDesconto.Text = "REALIZE O DESCONTO!";
                    txtValorCompra.Focus();
                    break;
                case 3:
                    lbDesconto.Text = "Cliente do tipo PREMIUM Recebe 12% de Desconto";
                    porcentagem = 0.12;
                    lbDesconto.Visible = true;
                    txtDesconto.Text = "REALIZE O DESCONTO!";
                    txtValorCompra.Focus();
                    break;
                default:
                    cbOpcao.SelectedIndex = 0;
                    break;
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valorCompra, valorDesconto, total;
            int op = cbOpcao.SelectedIndex;
                   valorCompra = Double.Parse(txtValorCompra.Text);
                    valorDesconto = valorCompra * porcentagem;
                    txtDesconto.Text = valorDesconto.ToString("C");
                    total = valorCompra - valorDesconto;
                    txtTotalDescoto.Text = total.ToString("C");
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCalcular_Click(sender,e);
            }
        }
    }
}
