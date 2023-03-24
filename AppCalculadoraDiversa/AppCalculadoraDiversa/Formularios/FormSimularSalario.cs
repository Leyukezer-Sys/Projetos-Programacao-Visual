using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadoraDiversa.Formularios
{
    public partial class FormSimularSalario : Form
    {
        public FormSimularSalario()
        {
            InitializeComponent();
            lbResposta.Visible = false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbOpcao.SelectedIndex = -1;
            txtSalario.Clear();
            txtVenda.Clear();
            cbOpcao.Focus();
            lbResposta.Text = "...";
            lbResposta.Visible = false;
        }

        private void btSimular_Click(object sender, EventArgs e)
        {
            double venda = 0.0, salario = 0.0, total = 0.0;
            int op = cbOpcao.SelectedIndex;
            switch (op)
            {
                case 0:
                    //ESTAGIARIO
                    break;
                case 1:
                    //JUNIOR
                    break;
                case 2:
                    //PLENO
                    break;
                case 3:
                    //SENIOR
                    break;
                case 4:
                    //GERENTE
                    break;
            }
        }
    }
}
