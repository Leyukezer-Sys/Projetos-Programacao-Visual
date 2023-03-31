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
    public partial class FormSimularSalario : Form
    {
        double porcVenda = 0.0;
        public FormSimularSalario()
        {
            InitializeComponent();
            Message.Visible = false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbOpcao.SelectedIndex = -1;
            txtSalario.Clear();
            txtVenda.Clear();
            cbOpcao.Focus();
            lbResposta.Text = "...";
            Message.Visible = false;
        }

        private void btSimular_Click(object sender, EventArgs e)
        {
            double venda = 0.0, salario = 0.0, total = 0.0;
            int op = cbOpcao.SelectedIndex;
            if (op > -1 && op < 5)
            {
                venda = Double.Parse(txtVenda.Text);
                salario = Double.Parse(txtSalario.Text);

                total = (venda * porcVenda) + salario;

                Message.Visible = true;
                lbResposta.Text = $"o {cbOpcao.SelectedItem.ToString()} terá seu salário Final definido à {total.ToString("C")}";
            }
            else
            {
                MessageBox.Show("Selecione o Cargo do Vendedor!", "======= INFORMAÇÃO! =======", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op = cbOpcao.SelectedIndex;
            switch (op)
            {
                case 0:
                    porcVenda = 0.02;
                    break;
                case 1:
                    porcVenda = 0.05;
                    break;
                case 2:
                    porcVenda = 0.07;
                    break;
                case 3:
                    porcVenda = 0.10;
                    break;
                case 4:
                    porcVenda = 0.12;
                    break;
            }
        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSalario.Focus();
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btSimular_Click(sender, e);
            }
        }

        private void btMessage_Click(object sender, EventArgs e)
        {
            Message.Visible = false;
        }
    }
}
