namespace AppCalculadoraDiversa.Formularios
{
    partial class FormSimularSalario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSimular = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Panel();
            this.lbResposta = new System.Windows.Forms.Label();
            this.btMessage = new System.Windows.Forms.Button();
            this.Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIMULAR SALARIAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOpcao
            // 
            this.cbOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "ESTAGIARIO",
            "JÚNIOR",
            "PLENO",
            "SÊNIOR",
            "GERENTE"});
            this.cbOpcao.Location = new System.Drawing.Point(116, 90);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(348, 28);
            this.cbOpcao.TabIndex = 14;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecione o Cargo do Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "TOTAL DAS VENDAR:";
            // 
            // txtVenda
            // 
            this.txtVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtVenda.Location = new System.Drawing.Point(44, 182);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(207, 26);
            this.txtVenda.TabIndex = 16;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_KeyPress);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSalario.Location = new System.Drawing.Point(44, 271);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(207, 26);
            this.txtSalario.TabIndex = 18;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "INFORME SEU SALÁRIO:";
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.White;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btNovo.Location = new System.Drawing.Point(367, 272);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(167, 41);
            this.btNovo.TabIndex = 22;
            this.btNovo.Text = "NOVA SIMULAÇÃO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSimular
            // 
            this.btSimular.BackColor = System.Drawing.Color.White;
            this.btSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btSimular.Location = new System.Drawing.Point(367, 171);
            this.btSimular.Name = "btSimular";
            this.btSimular.Size = new System.Drawing.Size(167, 41);
            this.btSimular.TabIndex = 21;
            this.btSimular.Text = "SIMULAR";
            this.btSimular.UseVisualStyleBackColor = false;
            this.btSimular.Click += new System.EventHandler(this.btSimular_Click);
            // 
            // Message
            // 
            this.Message.AutoScroll = true;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Message.Controls.Add(this.btMessage);
            this.Message.Controls.Add(this.lbResposta);
            this.Message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Message.Location = new System.Drawing.Point(0, 319);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(584, 142);
            this.Message.TabIndex = 23;
            // 
            // lbResposta
            // 
            this.lbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbResposta.ForeColor = System.Drawing.Color.White;
            this.lbResposta.Location = new System.Drawing.Point(14, 22);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(448, 90);
            this.lbResposta.TabIndex = 18;
            this.lbResposta.Text = "...";
            // 
            // btMessage
            // 
            this.btMessage.BackColor = System.Drawing.Color.White;
            this.btMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btMessage.Location = new System.Drawing.Point(495, 48);
            this.btMessage.Name = "btMessage";
            this.btMessage.Size = new System.Drawing.Size(48, 41);
            this.btMessage.TabIndex = 23;
            this.btMessage.Text = "OK";
            this.btMessage.UseVisualStyleBackColor = false;
            this.btMessage.Click += new System.EventHandler(this.btMessage_Click);
            // 
            // FormSimularSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btSimular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimularSalario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "===== Simular Salario =====";
            this.Message.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSimular;
        private System.Windows.Forms.Panel Message;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Button btMessage;
    }
}