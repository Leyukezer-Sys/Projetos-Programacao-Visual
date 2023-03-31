namespace AppCalculadoraDiversa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btCalculadoraFinanceira = new System.Windows.Forms.Button();
            this.btCalcularDesconto = new System.Windows.Forms.Button();
            this.btCalcularRaizes = new System.Windows.Forms.Button();
            this.btSimularRaizes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalculadoraFinanceira
            // 
            this.btCalculadoraFinanceira.BackColor = System.Drawing.Color.Black;
            this.btCalculadoraFinanceira.Font = new System.Drawing.Font("Noto Sans", 14.25F);
            this.btCalculadoraFinanceira.ForeColor = System.Drawing.Color.White;
            this.btCalculadoraFinanceira.Location = new System.Drawing.Point(64, 75);
            this.btCalculadoraFinanceira.Name = "btCalculadoraFinanceira";
            this.btCalculadoraFinanceira.Size = new System.Drawing.Size(353, 57);
            this.btCalculadoraFinanceira.TabIndex = 2;
            this.btCalculadoraFinanceira.Text = "CALCULADORA FINANCEIRA";
            this.btCalculadoraFinanceira.UseVisualStyleBackColor = false;
            this.btCalculadoraFinanceira.Click += new System.EventHandler(this.btCalculadoraFinanceira_Click);
            // 
            // btCalcularDesconto
            // 
            this.btCalcularDesconto.BackColor = System.Drawing.Color.Gray;
            this.btCalcularDesconto.Font = new System.Drawing.Font("Noto Sans", 14.25F);
            this.btCalcularDesconto.ForeColor = System.Drawing.Color.White;
            this.btCalcularDesconto.Location = new System.Drawing.Point(66, 152);
            this.btCalcularDesconto.Name = "btCalcularDesconto";
            this.btCalcularDesconto.Size = new System.Drawing.Size(353, 57);
            this.btCalcularDesconto.TabIndex = 3;
            this.btCalcularDesconto.Text = "CALCULADORA DESCONTO";
            this.btCalcularDesconto.UseVisualStyleBackColor = false;
            this.btCalcularDesconto.Click += new System.EventHandler(this.btCalcularDesconto_Click);
            // 
            // btCalcularRaizes
            // 
            this.btCalcularRaizes.BackColor = System.Drawing.Color.SteelBlue;
            this.btCalcularRaizes.Font = new System.Drawing.Font("Noto Sans", 14.25F);
            this.btCalcularRaizes.ForeColor = System.Drawing.Color.White;
            this.btCalcularRaizes.Location = new System.Drawing.Point(64, 229);
            this.btCalcularRaizes.Name = "btCalcularRaizes";
            this.btCalcularRaizes.Size = new System.Drawing.Size(353, 57);
            this.btCalcularRaizes.TabIndex = 4;
            this.btCalcularRaizes.Text = "CALCULADORA RAIZES";
            this.btCalcularRaizes.UseVisualStyleBackColor = false;
            this.btCalcularRaizes.Click += new System.EventHandler(this.btCalcularRaizes_Click);
            // 
            // btSimularRaizes
            // 
            this.btSimularRaizes.BackColor = System.Drawing.Color.Maroon;
            this.btSimularRaizes.Font = new System.Drawing.Font("Noto Sans", 14.25F);
            this.btSimularRaizes.ForeColor = System.Drawing.Color.White;
            this.btSimularRaizes.Location = new System.Drawing.Point(66, 304);
            this.btSimularRaizes.Name = "btSimularRaizes";
            this.btSimularRaizes.Size = new System.Drawing.Size(353, 57);
            this.btSimularRaizes.TabIndex = 5;
            this.btSimularRaizes.Text = "SIMULAR SALÁRIO";
            this.btSimularRaizes.UseVisualStyleBackColor = false;
            this.btSimularRaizes.Click += new System.EventHandler(this.btSimularRaizes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.btSimularRaizes);
            this.Controls.Add(this.btCalcularRaizes);
            this.Controls.Add(this.btCalcularDesconto);
            this.Controls.Add(this.btCalculadoraFinanceira);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "===== MAIN =====";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalculadoraFinanceira;
        private System.Windows.Forms.Button btCalcularDesconto;
        private System.Windows.Forms.Button btCalcularRaizes;
        private System.Windows.Forms.Button btSimularRaizes;
    }
}

