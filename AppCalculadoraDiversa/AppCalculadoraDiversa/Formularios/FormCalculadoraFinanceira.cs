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
    public partial class FormCalculadoraFinanceira : Form
    {
        public FormCalculadoraFinanceira()
        {
            InitializeComponent();
            cbOpcao.SelectedIndex = -1;

            txtJuros.BackColor = Color.IndianRed;
            txtJuros.ReadOnly = true;
        }
        public  void NovoCalculo()
        {
            txtMontante.BackColor = SystemColors.Window;
            txtMontante.ReadOnly = false;
            txtCapital.BackColor = SystemColors.Window;
            txtCapital.ReadOnly = false;            
            txtTaxa.BackColor = SystemColors.Window;
            txtTaxa.ReadOnly = false;            
            txtTempo.BackColor = SystemColors.Window;
            txtTempo.ReadOnly = false;            
        }
        public void CalcularMontante()
        {
            
        }
        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbOpcao.SelectedIndex;
            switch (index)
            {
                case 0:
                    NovoCalculo();
                    txtMontante.BackColor = Color.LightGreen;
                    txtMontante.ReadOnly = true;
                    break;
                case 1:
                    NovoCalculo();
                    txtCapital.BackColor = Color.LightGreen;
                    txtCapital.ReadOnly = true;
                    break;
                case 2:
                    NovoCalculo();
                    txtTaxa.BackColor = Color.LightGreen;
                    txtTaxa.ReadOnly = true;
                    break;
                case 3:
                    NovoCalculo();
                    txtTempo.BackColor = Color.LightGreen;
                    txtTempo.ReadOnly = true;
                    break;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbOpcao.SelectedIndex = -1;
            NovoCalculo();

            txtMontante.Text = "";
            txtCapital.Text = "";
            txtTaxa.Text = "";
            txtTempo.Text = "";
            txtJuros.Text = "";
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double montante, capital, juros, taxa;
            int tempo;
            /*
            montante = Double.Parse(txtMontante.Text);
            capital = Double.Parse(txtMontante.Text);
            taxa = Int32.Parse(txtTaxa.Text)/100;
            tempo = Int32.Parse(txtTempo.Text);
            */
            if(cbOpcao.SelectedIndex == 0)
            {
                //montante M = C * (1 + I * T)
                capital = Double.Parse(txtCapital.Text);
                taxa = Double.Parse(txtTaxa.Text);
                taxa /= 100;
                tempo = Int32.Parse(txtTempo.Text);

                montante = capital * (1 + taxa * tempo);
                juros = capital * taxa * tempo;

                txtMontante.Text = montante.ToString("C");
                txtJuros.Text = juros.ToString("C");
            }
            if (cbOpcao.SelectedIndex == 1)
            {
                //Capital C = M /(1 + I)^t
                montante = Double.Parse(txtMontante.Text);
                taxa = Double.Parse(txtTaxa.Text);
                taxa /= 100;
                tempo = Int32.Parse(txtTempo.Text);

                capital = montante / (1 + taxa * tempo);
                juros = capital * taxa * tempo;

                txtCapital.Text = capital.ToString("C");
                txtJuros.Text = juros.ToString("C");
            }
            if (cbOpcao.SelectedIndex == 2)
            {
                //taxa
                montante = Double.Parse(txtMontante.Text);
                capital = Double.Parse(txtCapital.Text);
                tempo = Int32.Parse(txtTempo.Text);

                taxa = (montante - capital) / (capital * tempo);
                
                juros = montante - capital;
                taxa *= 100;

                txtTaxa.Text = taxa.ToString()+"%";
                txtJuros.Text = juros.ToString("C");
            }
            if (cbOpcao.SelectedIndex == 3)
            {
                //tempo
                double tempoF = 0.0;
                montante = Double.Parse(txtMontante.Text);
                capital = Double.Parse(txtCapital.Text);
                taxa = Int32.Parse(txtTaxa.Text);
                taxa /= 100;

                tempoF = (montante - capital) / (capital * taxa);

                juros = montante - capital;

                txtTempo.Text = tempoF.ToString("N0");
                txtJuros.Text = juros.ToString("C");
            }
        }
    }
}
