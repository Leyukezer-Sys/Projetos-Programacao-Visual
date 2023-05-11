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
            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtNome.Text,
                               txtCpf.Text,
                               txtSalario.Text,
                               txtReajuste.Text,
                               txtSalarioAtual.Text
                               );
            btCancelar_Click(sender,e);
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
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtReajuste.Select();
            }
        }

        private void txtReajuste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double salario = double.Parse(txtSalario.Text);
                double reajuste = double.Parse(txtReajuste.Text)/100;
                double salarioAtual = salario * (1+reajuste);

                txtSalarioAtual.Text = salarioAtual.ToString("C");
                txtReajuste.Text = (reajuste * 100) + "%";

                txtSalarioAtual.Select();
            }
        }

        private void txtSalarioAtual_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNome.Focus();
            txtCpf.Clear();
            txtSalario.Clear();
            txtReajuste.Clear();
            txtSalarioAtual.Clear();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index;
            int qtdLinhas = dgvTabela.Rows.Count;
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
    }
}
