using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppSimuladorAluno.Formularios
{
    public partial class FormSimuladorMediaFinal : Form
    {
        public FormSimuladorMediaFinal()
        {
            InitializeComponent();
            lbResposta.Visible = false;
        }

        private void btSimularMedia_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double media = double.Parse(txtMedia.Text), exame = double.Parse(txtExameFinal.Text);
            double mediaFinal = (6 * media + 4 * exame) / 10;
            if (media > 49)
            {
                lbResposta.Text = $"{nome}, você foi aprovado(a). com {mediaFinal.ToString("N1")} pontos";

                lbResposta.Visible = true;
            }
            else
            {
                lbResposta.Text = $"{nome}, você não foi aprovado(a) com {mediaFinal.ToString("N1")} pontos";
                lbResposta.Visible = true;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtExameFinal.Clear();
            txtMedia.Clear();
            txtNome.Clear();
            txtNome.Focus();
            lbResposta.Visible = false;
        }
    }
}
