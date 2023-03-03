using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorHorasEmMinutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double horas = Convert.ToDouble(txtHora.Text), minutos;

            minutos = horas * 60;

            txtMinuto.Text = minutos.ToString();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtMinuto.Clear();
            txtHora.Clear();
            txtHora.Focus();
        }

        private void txtHora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btConverter_Click(sender, e);
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }
        }
    }
}
