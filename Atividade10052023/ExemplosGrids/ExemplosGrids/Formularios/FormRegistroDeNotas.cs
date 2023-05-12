using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ExemplosGrids.Formularios
{
    public partial class FormRegistroDeNotas : Form
    {
        public FormRegistroDeNotas()
        {
            InitializeComponent();
            Bloquear();
            btDeletar.Enabled = false;
            dgvTabela.Enabled = false;
        }
        private void Totalizar()
        {
            int cont = 0;
            double total = 0.0, soma = 0.0;
            for (int i = 0; i < dgvTabela.RowCount; i++)
            {
                soma += Convert.ToDouble(dgvTabela[3, i].Value);
                cont++;
            }
            total = soma / cont;
            txtMediaGeral.Text = total.ToString("N1");
        }
        private void LimparCampos()
        {
            txtNome.Focus();
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
        }
        private void Bloquear()
        {
            txtNome.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtMedia.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false; 
            btAdd.Enabled = true;
            btAdd.Focus();
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

            Totalizar();

            btDeletar.Enabled = false;

            DialogResult resp = MessageBox.Show
                     (
                         "Deseja Continuar?",
                         "ADS",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question
                     );
            if (resp == DialogResult.Yes)
            {
                LimparCampos();
            }
            else
            {
                Bloquear();
                LimparCampos();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show
                    (
                        "Deseja mesmo Cancelar?",
                        "ADS",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
            if (resp == DialogResult.Yes)
            {
                LimparCampos();
                Bloquear();
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index;
            int qtdLinhas = dgvTabela.Rows.Count;

            if (qtdLinhas < 3) btDeletar.Enabled = false;
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
                    Totalizar();
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

                txtMedia.Text = media.ToString("N1");
                btSalvar.Focus();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtNota1.Enabled = true;
            txtNota2.Enabled = true;
            txtMedia.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btAdd.Enabled = false;
            LimparCampos();
        }
    }
}
