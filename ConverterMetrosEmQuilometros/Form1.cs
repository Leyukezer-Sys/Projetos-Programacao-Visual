using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterMetrosEmQuilometros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double metro=Convert.ToDouble(txtMetro.Text),quilometro;

            quilometro = metro / 1000;

            txtQuilometro.Text = quilometro.ToString("N2")+" KM";
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtMetro.Clear();
            txtQuilometro.Clear();
            txtMetro.Clear();
        }

        private void txtMetro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btConverter_Click(sender, e);
        }

        private void txtMetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)) e.Handled = true;
        }
    }
}
