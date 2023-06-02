using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace FormExemploRegistrosEmArq.Formularios
{
    public partial class FormCadastro : Form
    {
        private int id;
        public FormCadastro()
        {
            InitializeComponent();
            btAdd.Enabled = false;
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            id++;
            StreamWriter sw = new StreamWriter("cad_veiculo.csv",true);
            string registro = $"{id};{txtModelo.Text};{txtPlaca.Text};{txtAno.Text}";
            sw.WriteLine(registro);

            MessageBox.Show("Cadastrado com Sucesso!");

            sw.Close();
            txtAno.Clear(); txtModelo.Clear(); txtPlaca.Clear();
            btAdd.Enabled = false;
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btAdd.Enabled = true;
            }
        }
    }
}
