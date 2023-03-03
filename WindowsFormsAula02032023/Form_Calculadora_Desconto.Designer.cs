namespace WindowsFormsAula02032023
{
    partial class Form_CalculadoraDesconto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorComDesconto = new System.Windows.Forms.TextBox();
            this.lbText1 = new System.Windows.Forms.Label();
            this.lbText2 = new System.Windows.Forms.Label();
            this.lbText3 = new System.Windows.Forms.Label();
            this.lbErro = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovoCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.txtValorCompra.Location = new System.Drawing.Point(55, 91);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(207, 29);
            this.txtValorCompra.TabIndex = 0;
            this.txtValorCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorCompra_KeyDown);
            this.txtValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCompra_KeyPress);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.txtDesconto.Location = new System.Drawing.Point(55, 183);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(207, 29);
            this.txtDesconto.TabIndex = 1;
            this.txtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyDown);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // txtValorComDesconto
            // 
            this.txtValorComDesconto.BackColor = System.Drawing.Color.Black;
            this.txtValorComDesconto.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.txtValorComDesconto.ForeColor = System.Drawing.Color.Lime;
            this.txtValorComDesconto.Location = new System.Drawing.Point(55, 347);
            this.txtValorComDesconto.Name = "txtValorComDesconto";
            this.txtValorComDesconto.Size = new System.Drawing.Size(207, 29);
            this.txtValorComDesconto.TabIndex = 2;
            this.txtValorComDesconto.MouseLeave += new System.EventHandler(this.txtValorComDesconto_MouseLeave);
            this.txtValorComDesconto.MouseHover += new System.EventHandler(this.txtValorComDesconto_MouseHover);
            // 
            // lbText1
            // 
            this.lbText1.AutoSize = true;
            this.lbText1.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbText1.Location = new System.Drawing.Point(50, 62);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(151, 26);
            this.lbText1.TabIndex = 3;
            this.lbText1.Text = "Valor da Compra:";
            // 
            // lbText2
            // 
            this.lbText2.AutoSize = true;
            this.lbText2.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbText2.Location = new System.Drawing.Point(50, 154);
            this.lbText2.Name = "lbText2";
            this.lbText2.Size = new System.Drawing.Size(190, 26);
            this.lbText2.TabIndex = 4;
            this.lbText2.Text = "Perc. De Desconto (%):";
            // 
            // lbText3
            // 
            this.lbText3.AutoSize = true;
            this.lbText3.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbText3.Location = new System.Drawing.Point(50, 318);
            this.lbText3.Name = "lbText3";
            this.lbText3.Size = new System.Drawing.Size(178, 26);
            this.lbText3.TabIndex = 5;
            this.lbText3.Text = "Valor Com Desconto:";
            // 
            // lbErro
            // 
            this.lbErro.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.lbErro.ForeColor = System.Drawing.Color.Red;
            this.lbErro.Location = new System.Drawing.Point(51, 393);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(252, 54);
            this.lbErro.TabIndex = 6;
            this.lbErro.Text = "ERRO MESSAGE";
            this.lbErro.UseMnemonic = false;
            this.lbErro.Visible = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Noto Serif Cond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(471, 45);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "CALCULADORA DE DESCONTO";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Black;
            this.btCalcular.Font = new System.Drawing.Font("Noto Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.Azure;
            this.btCalcular.Location = new System.Drawing.Point(55, 243);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(248, 44);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "CALCULAR DESCONTO";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovoCalculo
            // 
            this.btNovoCalculo.BackColor = System.Drawing.Color.Black;
            this.btNovoCalculo.Font = new System.Drawing.Font("Noto Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoCalculo.ForeColor = System.Drawing.Color.Azure;
            this.btNovoCalculo.Location = new System.Drawing.Point(309, 361);
            this.btNovoCalculo.Name = "btNovoCalculo";
            this.btNovoCalculo.Size = new System.Drawing.Size(150, 77);
            this.btNovoCalculo.TabIndex = 9;
            this.btNovoCalculo.Text = "NOVO CÁLCULO";
            this.btNovoCalculo.UseVisualStyleBackColor = false;
            this.btNovoCalculo.Click += new System.EventHandler(this.btNovoCalculo_Click);
            // 
            // Form_CalculadoraDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.btNovoCalculo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.lbText3);
            this.Controls.Add(this.lbText2);
            this.Controls.Add(this.lbText1);
            this.Controls.Add(this.txtValorComDesconto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValorCompra);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CalculadoraDesconto";
            this.ShowIcon = false;
            this.Text = "Calculadora De Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValorComDesconto;
        private System.Windows.Forms.Label lbText1;
        private System.Windows.Forms.Label lbText2;
        private System.Windows.Forms.Label lbText3;
        private System.Windows.Forms.Label lbErro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovoCalculo;
    }
}

