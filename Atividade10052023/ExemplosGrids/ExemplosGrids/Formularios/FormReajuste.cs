using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosGrids.Formularios
{
    public partial class FormReajuste : Form
    {
        public FormReajuste()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            double reajuste = int.Parse(txtReajuste.Text) / 100;
            dgvTabela.Rows.Add(txtNome.Text,
                               txtCpf.Text,
                               txtSalario);
        }
    }
}
