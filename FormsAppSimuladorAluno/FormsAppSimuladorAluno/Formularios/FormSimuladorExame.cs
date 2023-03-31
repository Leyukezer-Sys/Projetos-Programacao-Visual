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
    public partial class FormSimuladorExame : Form
    {
        public FormSimuladorExame()
        {
            InitializeComponent();
            lbResposta.Visible = false;
        }

        private void btSimularMedia_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double mediaF = double.Parse(txtMediaFinal.Text), NPEX = (500-6*mediaF)/4;
            lbResposta.Text = $"O Acadêmico {nome} precisa de {NPEX} pontos para aprovação.";
            lbResposta.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMediaFinal.Clear();
            txtNome.Clear();
            txtNome.Focus();
            lbResposta.Visible = false;
        }
    }
}
