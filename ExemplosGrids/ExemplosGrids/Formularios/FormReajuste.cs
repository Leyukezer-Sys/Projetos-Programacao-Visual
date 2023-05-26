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
    public partial class FormReajuste : Form
    {
        public FormReajuste()
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
                soma += Convert.ToDouble(dgvTabela[4, i].Value);
                cont++;
            }
            total = soma / (cont - 1);
            txtTotal.Text = total.ToString("C2");
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtNome.Focus();
            txtCpf.Clear();
            txtSalario.Clear();
            txtReajuste.Clear();
            txtSalarioAtual.Clear();
        }
        private void Bloquear()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtSalario.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalarioAtual.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            btAdd.Enabled = true;
            btAdd.Focus();
            LimparCampos();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtSalario.Enabled = true;
            txtReajuste.Enabled = true;
            txtSalarioAtual.Enabled = true;
            btCancelar.Enabled = true;
            btAdd.Enabled = false;
            LimparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtNome.Text,
                               txtCpf.Text,
                               double.Parse(txtSalario.Text),
                               txtReajuste.Text,
                               double.Parse(txtSalarioAtual.Text)
                               );
            Totalizar();
            btDeletar.Enabled = true;
            dgvTabela.Enabled = true;

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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCpf.Select();
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSalario.Select();
            }
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtReajuste.Select();
            }
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 )
            {
                e.Handled = true;
            }
        }

        private void txtReajuste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double salario = double.Parse(txtSalario.Text);
                double reajuste = double.Parse(txtReajuste.Text)/100;
                double salarioAtual = salario * (1+reajuste);

                txtSalarioAtual.Text = salarioAtual.ToString("N2");
                reajuste = (reajuste * 100);
                txtReajuste.Text = reajuste.ToString("N1") + "%";

                btSalvar.Enabled = true;
                btSalvar.Select();
            }
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSalarioAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show
                    (
                        "Após digitar a porcentagem de reajuste pressione ENTER",
                        "ADS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                txtReajuste.Focus();

            }
            else
            {
                btSalvar_Click(sender, e);
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

            if (qtdLinhas < 3)
            {
                btDeletar.Enabled = true; 
            }
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

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
