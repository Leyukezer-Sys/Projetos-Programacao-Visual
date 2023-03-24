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
    public partial class FormCalcularRaizes : Form
    {
        public FormCalcularRaizes()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbOpcao.SelectedIndex = -1;
            lbBase.Text = "Informe a Base/Numero";
            txtBase.Clear();
            txtExpoente.Clear();
            txtResultado.Clear();
            cbOpcao.Focus();
            txtExpoente.Enabled = true;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int op = cbOpcao.SelectedIndex;
            double baze = 0, expoente = 0, result= 0;
            try
            {
                baze = Double.Parse(txtBase.Text);
                expoente = Double.Parse(txtExpoente.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se preencheu as Informações Corretamente");
                
            }
            if (op > -1 && op < 4)
            {
                if (op == 3)
                {
                    double exp = 1 / expoente;
                    result = Math.Pow(baze, exp);
                    txtResultado.Text = result.ToString("N2");
                }
                else if (op != 3)
                {
                    result = Math.Pow(baze, expoente);
                    txtResultado.Text = result.ToString("N2");

                }
            }
            else
            {
                MessageBox.Show("Selecione a Operação!", "======= INFORMAÇÃO! =======", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op = cbOpcao.SelectedIndex;
            double exp = 0.0;


            switch (op)
            {
                case 0:
                    //POTENCIA
                    txtExpoente.Enabled = true;
                    txtExpoente.Clear();
                    lbBase.Text = "Informe a Base/Numero";
                    break;
                case 1:
                    //RAIZ QUADRADA
                    txtExpoente.Enabled = false;
                    exp = 1.0 / 2.0;
                    txtExpoente.Text = exp.ToString();
                    lbBase.Text = "Informe o Radicando";
                    break;
                case 2:
                    //RAIZ CUBICA
                    txtExpoente.Enabled = false;
                    exp = 1.0 / 3.0;
                    txtExpoente.Text = exp.ToString("");
                    lbBase.Text = "Informe o Radicando:";
                    break;
                case 3:
                    //RAIZ Enezima
                    txtExpoente.Enabled = true;
                    txtExpoente.Clear();
                    lbBase.Text = "Informe o Radicando:";
                    break;
            }
        }

        private void txtExpoente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btCalcular_Click(sender, e);
            }
        }

        private void txtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            int op = cbOpcao.SelectedIndex;

            switch (op)
            {
                case 0:
                    //POTENCIA
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        txtExpoente.Focus();
                    }
                    break;
                case 1:
                    //RAIZ QUADRADA
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        btCalcular_Click(sender, e);
                    }
                    break;
                case 2:
                    //RAIZ CUBICA
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        btCalcular_Click(sender, e);
                    }
                    break;
                case 3:
                    //RAIZ ENESIMA
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        btCalcular_Click(sender, e);
                    }
                    break;
                case 4:
                    //RAIZ
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        txtExpoente.Focus();
                    }
                    break;
            }
        }
    }
}
