namespace AppCalculadoraDiversa.Formularios
{
    partial class FormCalculadoraDesconto
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.txtTotalDescoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "DESCONTO DAS COMPRAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe o Total da Compra";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbOpcao
            // 
            this.cbOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "COMUM",
            "ESPECIAL",
            "VIP",
            "PRÊMIUM"});
            this.cbOpcao.Location = new System.Drawing.Point(115, 83);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(348, 28);
            this.cbOpcao.TabIndex = 14;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtValorCompra.Location = new System.Drawing.Point(56, 167);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(207, 26);
            this.txtValorCompra.TabIndex = 15;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCompra_KeyPress);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDesconto.Location = new System.Drawing.Point(56, 267);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(207, 26);
            this.txtDesconto.TabIndex = 17;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Valor do Desconto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDesconto
            // 
            this.lbDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesconto.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbDesconto.Location = new System.Drawing.Point(52, 214);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(520, 25);
            this.lbDesconto.TabIndex = 18;
            this.lbDesconto.Text = "...";
            this.lbDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalDescoto
            // 
            this.txtTotalDescoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTotalDescoto.Location = new System.Drawing.Point(56, 348);
            this.txtTotalDescoto.Name = "txtTotalDescoto";
            this.txtTotalDescoto.Size = new System.Drawing.Size(207, 26);
            this.txtTotalDescoto.TabIndex = 20;
            this.txtTotalDescoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Valor Final com Desconto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.White;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btNovo.Location = new System.Drawing.Point(320, 408);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(252, 41);
            this.btNovo.TabIndex = 22;
            this.btNovo.Text = "NOVO DESCONTO";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.White;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btCalcular.Location = new System.Drawing.Point(35, 408);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(244, 41);
            this.btCalcular.TabIndex = 21;
            this.btCalcular.Text = "REALIZAR DESCONTO";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Selecione o Tipo de Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCalculadoraDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtTotalDescoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDesconto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadoraDesconto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "===== Calculadora Desconto =====";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.TextBox txtTotalDescoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label3;
    }
}