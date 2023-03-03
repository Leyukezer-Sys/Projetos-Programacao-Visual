using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorHectaresParaAlquueire
{
    public partial class Form_Convert_Hec_Alq : Form
    {
        public Form_Convert_Hec_Alq()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtAlqueire.Clear();
            txtHectare.Clear();
            txtHectare.Focus();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            double hectare = Convert.ToDouble(txtHectare.Text),alqueire;

            alqueire = hectare / 2.42;

            txtAlqueire.Text = alqueire.ToString("N1");
        }

        private void txtHectare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btConverter_Click(sender,e);
        }
    }
}
