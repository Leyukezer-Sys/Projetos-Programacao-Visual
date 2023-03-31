using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppSimuladorAluno.Formularios
{
    public partial class FormSimuladorMedia : Form
    {
        public FormSimuladorMedia()
        {
            InitializeComponent();
            lbResposta.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNome.Focus();
            lbResposta.Visible = false;
        }

        private void btSimularMedia_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double nota1 = double.Parse(txtNota1.Text), nota2 = double.Parse(txtNota2.Text);
            double media = (nota1 + nota2) / 2;
            if (media > 59)
            {
                lbResposta.Text = $"{nome}, você foi aprovado(a) com {media.ToString("N1")} pontos";

                lbResposta.Visible = true;
            }
            else
            {
                lbResposta.Text = $"{nome}, você foi reprovado(a) com {media.ToString("N1")} pontos";
                lbResposta.Visible = true;
            }
        }

        private void lbResposta_Click(object sender, EventArgs e)
        {

        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btSimularMedia_Click(sender, e);
            }
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNota2.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNota1.Focus();
            }
        }
    }
}
