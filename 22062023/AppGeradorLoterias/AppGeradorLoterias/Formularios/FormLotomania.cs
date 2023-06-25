using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormLotomania : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        public FormLotomania()
        {
            InitializeComponent();
        }
        public void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;

            if (impar == 10 && par == 10) { lbClass.Text = "MUITO ALTO!"; lbClass.ForeColor = Color.Green; }
            else
            if (impar == 11 && par == 9) { lbClass.Text = "ALTO!"; lbClass.ForeColor = Color.YellowGreen; }
            else
            if (impar == 9 && par == 11) { lbClass.Text = "MÉDIO!"; lbClass.ForeColor = Color.Orange; }
            else
            if (impar == 12 && par == 8) { lbClass.Text = "BAIXO!"; lbClass.ForeColor = Color.OrangeRed; }
            else { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
        }
        public void GerarNumeros()
        {
            int numero = 0, cont = 0, qtdPar = 0, qtdImpar = 0;
            Random radNum = new Random();
            NumerosDaSorte.Clear();

            while (cont < 20)
            {
                numero = radNum.Next(1, 101);
                if (!NumerosDaSorte.Contains(numero))
                {
                    NumerosDaSorte.Add(numero);
                    if (numero % 2 == 0) qtdPar++;
                    if (numero % 2 != 0) qtdImpar++;
                    cont++;
                }
            }

            NumerosDaSorte = NumerosDaSorte.OrderBy(num => num).ToList();
            Comparacao(qtdPar, qtdImpar);
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
        }
        public void LimparTabela()
        {
            NumerosDaSorte.Clear();
            dtvNumeros.DataSource = NumerosDaSorte.Select((Numeros) => new { Numero = Numeros }).ToList();

        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            GerarNumeros();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparTabela();
            lbClass.Text = "CLASSIFICAÇÃO";
            lbClass.ForeColor = Color.Blue;
            lbPar.Text = "PARES";
            lbImpar.Text = "ÍMPARES";
        }
    }
}
