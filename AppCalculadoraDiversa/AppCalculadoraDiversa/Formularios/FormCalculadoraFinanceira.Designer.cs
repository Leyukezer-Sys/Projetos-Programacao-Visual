namespace AppCalculadoraDiversa.Formularios
{
    partial class FormCalculadoraFinanceira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadoraFinanceira));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione a opção de Calculo";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "FINANCEIRO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOpcao
            // 
            this.cbOpcao.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "MONTANTE",
            "CAPITAL",
            "TAXA",
            "TEMPO"});
            this.cbOpcao.Location = new System.Drawing.Point(119, 83);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(348, 30);
            this.cbOpcao.TabIndex = 4;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "MONTANTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(354, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "CAPITAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "TAXA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(354, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "TEMPO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "JUROS";
            // 
            // txtMontante
            // 
            this.txtMontante.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtMontante.Location = new System.Drawing.Point(69, 168);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(167, 30);
            this.txtMontante.TabIndex = 10;
            this.txtMontante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtCapital.Location = new System.Drawing.Point(358, 168);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(167, 30);
            this.txtCapital.TabIndex = 11;
            this.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtTaxa.Location = new System.Drawing.Point(69, 262);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(167, 30);
            this.txtTaxa.TabIndex = 12;
            this.txtTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtTempo.Location = new System.Drawing.Point(358, 262);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(167, 30);
            this.txtTempo.TabIndex = 13;
            this.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJuros
            // 
            this.txtJuros.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtJuros.Location = new System.Drawing.Point(69, 351);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(167, 30);
            this.txtJuros.TabIndex = 14;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.White;
            this.btCalcular.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.btCalcular.Location = new System.Drawing.Point(358, 333);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(167, 41);
            this.btCalcular.TabIndex = 15;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.White;
            this.btNovo.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.btNovo.Location = new System.Drawing.Point(358, 396);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(167, 41);
            this.btNovo.TabIndex = 16;
            this.btNovo.Text = "NOVO CÁLCULO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCalculadoraFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadoraFinanceira";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "===== Calculadora Financeira =====";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
    }
}