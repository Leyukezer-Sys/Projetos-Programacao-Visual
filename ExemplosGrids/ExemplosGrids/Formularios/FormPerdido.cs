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
    public partial class FormPerdido : Form
    {
        public FormPerdido()
        {
            InitializeComponent();

            // Bloquear campos de edição
            Bloquear();
            dgvTabela.Enabled = false;
            btDeletar.Enabled = false;
        }

        private void Bloquear()
        {
            txtDescricao.Enabled = false;
            txtQuant.Enabled = false;
            txtTotal.Enabled = false;
            txtValorUnit.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            btAdd.Enabled = true;
            btAdd.Focus();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtDescricao.Focus();
            txtQuant.Clear();
            txtValorUnit.Clear();
            txtTotal.Clear();
        }

        private void Totalizar()
        {
            double total = 0.0;
            for (int i = 0;i < dgvTabela.RowCount; i++)
            {
                total += Convert.ToDouble(dgvTabela[3, i].Value);
            }
            txtTotalGeral.Text = total.ToString("C2");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtQuant.Enabled = true;
            txtTotal.Enabled = true;
            txtValorUnit.Enabled = true;
            btCancelar.Enabled = true;
            LimparCampos();

            btAdd.Enabled = false;
            btDeletar.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add
                (
                    txtDescricao.Text,
                    double.Parse(txtValorUnit.Text),
                    int.Parse(txtQuant.Text),
                    double.Parse(txtTotal.Text)
                );
            Totalizar();

            btAdd.Enabled = true;
            btDeletar.Enabled = true;
            dgvTabela.Enabled = true;

            DialogResult resp = MessageBox.Show
                     (
                         "Deseja adicionar outro?",
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
                LimparCampos();
                Bloquear();
            }
            
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show
                    (
                        "Após digitar a quantidade pressione ENTER",
                        "ADS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                txtQuant.Focus();
            }
            else
            {
                btSalvar_Click (sender, e);
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
                btAdd.Enabled = true;
            }
        }

        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double quant = double.Parse(txtQuant.Text);
                double valorUnit = double.Parse(txtValorUnit.Text);
                double total = quant * valorUnit;
                txtTotal.Text = total.ToString();
                txtTotal.Focus();

                btSalvar.Enabled = true;
            }
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index;
            int qtdLinhas = dgvTabela.RowCount;
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

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValorUnit.Focus();
            }
        }

        private void txtValorUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtQuant.Focus();
            }
            if (!char.IsNumber(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTotalGeral_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
