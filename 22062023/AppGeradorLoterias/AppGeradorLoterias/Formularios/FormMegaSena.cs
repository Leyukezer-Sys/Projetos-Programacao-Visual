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
    public partial class FormMegaSena : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        public FormMegaSena()
        {
            InitializeComponent();
        }
        public void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;

            if (impar == 3 && par == 3) { lbClass.Text = "MUITO ALTO!"; lbClass.ForeColor = Color.Green; }
            else
            if (impar == 4 && par == 2) { lbClass.Text = "ALTO!"; lbClass.ForeColor = Color.YellowGreen; }
            else
            if (impar == 2 && par == 4) { lbClass.Text = "MÉDIO!"; lbClass.ForeColor = Color.Orange; }
            else
            if (impar == 1 && par == 5) { lbClass.Text = "BAIXO!"; lbClass.ForeColor = Color.OrangeRed; }
            else { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
        }

        public void GerarNumeros()
        {
            int numero = 0, cont = 0, qtdPar = 0, qtdImpar = 0;
            Random radNum = new Random();
            NumerosDaSorte.Clear();

            while (cont < 6)
            {
                numero = radNum.Next(1, 61);
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
            lbClass.ForeColor = Color.ForestGreen;
            lbPar.Text = "PARES";
            lbImpar.Text = "ÍMPARES";
        }
    }
}
