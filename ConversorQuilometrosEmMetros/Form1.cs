using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorQuilometrosEmMetros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtQuilometro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btConverter_Click(sender,e);
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double quilometros = Convert.ToDouble(txtQuilometro.Text), metro;

            metro =  quilometros * 1000;

            txtMetro.Text = metro.ToString("N2") + " M";
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtMetro.Clear();
            txtQuilometro.Clear();
            txtQuilometro.Focus();
        }
    }
}
