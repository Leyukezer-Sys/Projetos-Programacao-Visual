﻿using FormsAppSimuladorAluno.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppSimuladorAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSimularMedia_Click(object sender, EventArgs e)
        {
            FormSimuladorMedia form = new FormSimuladorMedia();
            form.ShowDialog();
        }

        private void btAprovarExame_Click(object sender, EventArgs e)
        {
            FormSimuladorExame form = new FormSimuladorExame();
            form.ShowDialog();
        }

        private void btMediaFinal_Click(object sender, EventArgs e)
        {
            FormSimuladorMediaFinal form = new FormSimuladorMediaFinal();
            form.ShowDialog();
        }
    }
}
