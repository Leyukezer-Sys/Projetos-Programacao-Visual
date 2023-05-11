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
    public partial class FormRegistroDeNotas : Form
    {
        double mediaGeral = 0, somaGeral = 0;
        public FormRegistroDeNotas()
        {
            InitializeComponent();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNota1.Focus();
            }
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNota2.Focus();
            }
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
            else
            {
                btSalvar_Click(sender, e);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add
                (
                    txtNome.Text,
                    double.Parse(txtNota1.Text),
                    double.Parse(txtNota2.Text),
                    double.Parse(txtMedia.Text)
                );
            int linhas = dgvTabela.RowCount;

            mediaGeral = somaGeral / linhas;
            txtMediaGeral.Text = mediaGeral.ToString("N1");

            btCancelar_Click(sender, e);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index;
            int qtdLinhas = dgvTabela.Rows.Count;
            double mediaSub = 0.0;

            if (qtdLinhas > 1)
            {
                

                DialogResult resp = MessageBox.Show
                    (
                        "Deseja mesmo Deletar?",
                        "ADS",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                if (resp == DialogResult.Yes)
                {
                    dgvTabela.Rows.RemoveAt(linha);
                }
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);
                double media = (nota1 + nota2) / 2;

               somaGeral += media;

                txtMedia.Text = media.ToString("N1");
                txtMedia.Focus();
            }
        }
    }
}
