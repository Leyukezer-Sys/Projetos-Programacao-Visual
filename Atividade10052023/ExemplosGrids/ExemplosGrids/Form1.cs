using ExemplosGrids.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosGrids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFormReajuste_Click(object sender, EventArgs e)
        {
            FormReajuste form = new FormReajuste();
            form.ShowDialog();
        }

        private void btPedido_Click(object sender, EventArgs e)
        {
            FormPerdido form = new FormPerdido();
            form.ShowDialog();
        }

        private void btRegistroNotas_Click(object sender, EventArgs e)
        {
            FormRegistroDeNotas form = new FormRegistroDeNotas();
            form.ShowDialog();
        }
    }
}
