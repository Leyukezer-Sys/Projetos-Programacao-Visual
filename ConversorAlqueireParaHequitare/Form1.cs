using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorAlqueireParaHequitare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtAlqueirePaulista.Clear();
            txtHectare.Clear();
            txtAlqueirePaulista.Focus();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double alqueire = Convert.ToDouble(txtAlqueirePaulista.Text), hectare;

            hectare =  alqueire * 2.42;

            txtHectare.Text = hectare.ToString("N1");
        }

        private void txtAlqueirePaulista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btConverter_Click(sender, e);
        }
    }
}
