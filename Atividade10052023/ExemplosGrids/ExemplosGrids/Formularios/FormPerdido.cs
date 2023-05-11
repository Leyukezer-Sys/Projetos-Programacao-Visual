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
    public partial class FormPerdido : Form
    {
        public FormPerdido()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add
                (
                    txtDescricao.Text,
                    double.Parse(txtValorUnit.Text),
                    int.Parse(txtQuant.Text),
                    txtTotal.Text
                );
            btCancelar_Click(sender, e);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtDescricao.Focus();
            txtQuant.Clear();
            txtValorUnit.Clear();
            txtTotal.Clear();
        }

        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double quant = double.Parse(txtQuant.Text);
                double valorUnit = double.Parse(txtValorUnit.Text);
                double total = quant * valorUnit;
                txtTotal.Text = total.ToString("C");
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index;
            int qtdLinhas = dgvTabela.Rows.Count;
            if ( qtdLinhas > 1 ) 
            {
                DialogResult resp = MessageBox.Show
                    (
                        "Deseja mesmo Deletar?",
                        "ADS",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                if ( resp == DialogResult.Yes )
                {
                    dgvTabela.Rows.RemoveAt(linha);
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
        }
    }
}
