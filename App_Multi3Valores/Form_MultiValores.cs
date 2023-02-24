using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Multi3Valores
{
    public partial class Multiplicacao : Form
    {
        public Multiplicacao()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor3.Clear();
            txtValor1.Focus();
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, resultado;

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);
            valor3 = Convert.ToDouble(txtValor3.Text);

            resultado = valor1 * valor2 * valor3;

            txtResultado.Text = resultado.ToString();
        }
    }
}
