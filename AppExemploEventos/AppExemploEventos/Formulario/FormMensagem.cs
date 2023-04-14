using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploEventos.Formulario
{
    public partial class FormMensagem : Form
    {
        public FormMensagem()
        {
            InitializeComponent();
        }
        public void AlertaMessage(string message, string titulo)
        {
            MessageBox.Show(message, titulo, MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        public void InformationMessage(string message, string titulo)
        {
            MessageBox.Show(message, titulo, MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void ErroMessage(string message, string titulo)
        {
            MessageBox.Show(message, titulo, MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public void QuestionamentoMessage(string message, string titulo)
        {
            MessageBox.Show(message, titulo, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
        }
        public int RepetirMessage(string message, string titulo)
        {
            DialogResult resp;
            int op = 0;
            resp = MessageBox.Show(message, titulo, MessageBoxButtons.RetryCancel,MessageBoxIcon.Question);
            do
            {
                resp = MessageBox.Show(message, titulo, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    op = 1;
                }
            }while(op == 1);
            return op;
        }
        private void btAlerta_Click(object sender, EventArgs e)
        {
            AlertaMessage("Não é possivel fazer divisão por Zero","ADS 2023");
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            InformationMessage("A Reposta é ...", "ADS 2023");
        }

        private void btErro_Click(object sender, EventArgs e)
        {
            ErroMessage("Digite numeros Inteiros", "ADS 2023");
        }

        private void btPergunta_Click(object sender, EventArgs e)
        {
            QuestionamentoMessage("Deseja continuar?", "ADS 2023");
        }

        private void btResposta_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string pergunta = "Tem Certeza dessa ação", titulo = "ADS 2022-2";
            resp = MessageBox.Show(pergunta,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                
                InformationMessage("Obrigado!", titulo);
            }
            else
            {
                ErroMessage("OK...", titulo);
            }
        }
    }
}
