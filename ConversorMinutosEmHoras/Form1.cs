using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMinutosEmHoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double minutos = Convert.ToDouble(txtMinuto.Text), horas;

            horas = minutos/60;

            txtHora.Text = horas.ToString("N1");
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtHora.Clear();
            txtMinuto.Clear();
            txtMinuto.Focus();
        }

        private void txtMinuto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btConverter_Click(sender, e);
            }
        }

        private void txtMinuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
