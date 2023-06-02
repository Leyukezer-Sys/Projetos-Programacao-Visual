using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormTemp.Formularios
{
    public partial class FormSinais : Form
    {
        int cont = 0;
        public FormSinais()
        {
            InitializeComponent();
            timerVerde.Start();
        }

        private void timerVerde_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont > 5)
            {
                btVerde.BackColor = Color.Green;
                btAmarelo.BackColor = Color.White;
                btVermelho.BackColor = Color.White;
            }
            if (cont > 10)
            {
                btVerde.BackColor = Color.White;
                btAmarelo.BackColor = Color.Yellow;
                btVermelho.BackColor = Color.White;
            }
            if (cont > 15)
            {
                btVerde.BackColor = Color.White;
                btAmarelo.BackColor = Color.White;
                btVermelho.BackColor = Color.Red;
                btVermelho.Text = "PARE!";
                btVermelho.ForeColor = Color.White;
                cont = 0;
            }
        }

        private void FormSinais_Load(object sender, EventArgs e)
        {

        }
    }
}
