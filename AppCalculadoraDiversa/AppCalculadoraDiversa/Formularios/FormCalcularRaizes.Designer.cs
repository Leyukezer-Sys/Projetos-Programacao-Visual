namespace AppCalculadoraDiversa.Formularios
{
    partial class FormCalcularRaizes
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lbBase = new System.Windows.Forms.Label();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpoente = new System.Windows.Forms.TextBox();
            this.lbExp = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "CALCULADORA DE POTÊNCIAS E RAÍZES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtBase.Location = new System.Drawing.Point(66, 171);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(207, 30);
            this.txtBase.TabIndex = 14;
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBase_KeyPress);
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.lbBase.ForeColor = System.Drawing.Color.Black;
            this.lbBase.Location = new System.Drawing.Point(62, 145);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(211, 23);
            this.lbBase.TabIndex = 13;
            this.lbBase.Text = "Informe o Numero/Base:";
            // 
            // cbOpcao
            // 
            this.cbOpcao.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "POTÊNCIA",
            "RAIZ QUADRADA",
            "RAIZ CÚBICA",
            "RAIZ ENÉSIMA"});
            this.cbOpcao.Location = new System.Drawing.Point(116, 86);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(348, 30);
            this.cbOpcao.TabIndex = 12;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(199, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecione a Operação";
            // 
            // txtExpoente
            // 
            this.txtExpoente.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtExpoente.Location = new System.Drawing.Point(66, 251);
            this.txtExpoente.Name = "txtExpoente";
            this.txtExpoente.Size = new System.Drawing.Size(207, 30);
            this.txtExpoente.TabIndex = 16;
            this.txtExpoente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpoente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpoente_KeyPress);
            // 
            // lbExp
            // 
            this.lbExp.AutoSize = true;
            this.lbExp.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.lbExp.ForeColor = System.Drawing.Color.Black;
            this.lbExp.Location = new System.Drawing.Point(62, 225);
            this.lbExp.Name = "lbExp";
            this.lbExp.Size = new System.Drawing.Size(174, 23);
            this.lbExp.TabIndex = 15;
            this.lbExp.Text = "Informe o Expoente:";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.White;
            this.btCalcular.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.btCalcular.Location = new System.Drawing.Point(355, 245);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(167, 41);
            this.btCalcular.TabIndex = 17;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.txtResultado.Location = new System.Drawing.Point(66, 357);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(207, 30);
            this.txtResultado.TabIndex = 19;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Resultado:";
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.White;
            this.btNovo.Font = new System.Drawing.Font("Noto Sans", 12.25F);
            this.btNovo.Location = new System.Drawing.Point(355, 346);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(167, 41);
            this.btNovo.TabIndex = 20;
            this.btNovo.Text = "NOVO CÁLCULO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCalcularRaizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtExpoente);
            this.Controls.Add(this.lbExp);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalcularRaizes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "===== Calcular Raizes =====";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpoente;
        private System.Windows.Forms.Label lbExp;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNovo;
    }
}