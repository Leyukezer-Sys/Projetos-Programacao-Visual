using AppFormTemp.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormTemp
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerPrimeiroTeste_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont % 2 == 0)
            {
                btParar.BackColor = Color.Blue;
                btParar.ForeColor = Color.White;
            }
            if (cont % 3 == 0)
            {
                btParar.BackColor = Color.White;
                btParar.ForeColor = Color.Black;
            }
            if (cont % 5 == 0)
            {
                btParar.BackColor = Color.Red;
                btParar.ForeColor = Color.White;
            }
        }

        private void btComecar_Click(object sender, EventArgs e)
        {
            timerPrimeiroTeste.Start();
        }

        private void btParar_Click(object sender, EventArgs e)
        {
            timerPrimeiroTeste.Stop();
            btParar.BackColor = Color.Black;
        }

        private void btSinaleiro_Click(object sender, EventArgs e)
        {
            FormSinais form = new FormSinais();
            form.ShowDialog();
        }
    }
}
