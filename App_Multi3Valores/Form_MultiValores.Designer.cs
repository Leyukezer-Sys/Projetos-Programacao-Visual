namespace App_Multi3Valores
{
    partial class Multiplicacao
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
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.lbValor3 = new System.Windows.Forms.Label();
            this.lbOperacao1 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btResultado = new System.Windows.Forms.Button();
            this.lbOperacao = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbValor2 = new System.Windows.Forms.Label();
            this.lbValor1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(800, 60);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Multiplicar Valores";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtValor3);
            this.panel1.Controls.Add(this.lbValor3);
            this.panel1.Controls.Add(this.lbOperacao1);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Controls.Add(this.btResultado);
            this.panel1.Controls.Add(this.lbOperacao);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.txtValor2);
            this.panel1.Controls.Add(this.txtValor1);
            this.panel1.Controls.Add(this.lbResultado);
            this.panel1.Controls.Add(this.lbValor2);
            this.panel1.Controls.Add(this.lbValor1);
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // txtValor3
            // 
            this.txtValor3.BackColor = System.Drawing.Color.LightGray;
            this.txtValor3.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtValor3.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtValor3.Location = new System.Drawing.Point(158, 344);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(99, 27);
            this.txtValor3.TabIndex = 16;
            // 
            // lbValor3
            // 
            this.lbValor3.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbValor3.ForeColor = System.Drawing.Color.White;
            this.lbValor3.Location = new System.Drawing.Point(42, 344);
            this.lbValor3.Name = "lbValor3";
            this.lbValor3.Size = new System.Drawing.Size(100, 23);
            this.lbValor3.TabIndex = 15;
            this.lbValor3.Text = "Valor 3:";
            // 
            // lbOperacao1
            // 
            this.lbOperacao1.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbOperacao1.ForeColor = System.Drawing.Color.White;
            this.lbOperacao1.Location = new System.Drawing.Point(154, 275);
            this.lbOperacao1.Name = "lbOperacao1";
            this.lbOperacao1.Size = new System.Drawing.Size(100, 23);
            this.lbOperacao1.TabIndex = 14;
            this.lbOperacao1.Text = "X";
            this.lbOperacao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Info;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btNovo.FlatAppearance.BorderSize = 5;
            this.btNovo.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold);
            this.btNovo.Location = new System.Drawing.Point(342, 247);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(154, 44);
            this.btNovo.TabIndex = 13;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btResultado
            // 
            this.btResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btResultado.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btResultado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btResultado.FlatAppearance.BorderSize = 5;
            this.btResultado.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold);
            this.btResultado.Location = new System.Drawing.Point(342, 155);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(154, 40);
            this.btResultado.TabIndex = 11;
            this.btResultado.Text = "Calcular";
            this.btResultado.UseVisualStyleBackColor = false;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // lbOperacao
            // 
            this.lbOperacao.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbOperacao.ForeColor = System.Drawing.Color.White;
            this.lbOperacao.Location = new System.Drawing.Point(157, 155);
            this.lbOperacao.Name = "lbOperacao";
            this.lbOperacao.Size = new System.Drawing.Size(100, 23);
            this.lbOperacao.TabIndex = 12;
            this.lbOperacao.Text = "X";
            this.lbOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.LightGray;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(608, 233);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(99, 27);
            this.txtResultado.TabIndex = 6;
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.LightGray;
            this.txtValor2.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtValor2.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtValor2.Location = new System.Drawing.Point(158, 213);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(99, 27);
            this.txtValor2.TabIndex = 5;
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.LightGray;
            this.txtValor1.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtValor1.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtValor1.Location = new System.Drawing.Point(158, 79);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(99, 27);
            this.txtValor1.TabIndex = 4;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbResultado.ForeColor = System.Drawing.Color.White;
            this.lbResultado.Location = new System.Drawing.Point(594, 141);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbResultado.Size = new System.Drawing.Size(142, 27);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.Text = "Resultado:";
            // 
            // lbValor2
            // 
            this.lbValor2.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbValor2.ForeColor = System.Drawing.Color.White;
            this.lbValor2.Location = new System.Drawing.Point(42, 213);
            this.lbValor2.Name = "lbValor2";
            this.lbValor2.Size = new System.Drawing.Size(100, 23);
            this.lbValor2.TabIndex = 2;
            this.lbValor2.Text = "Valor 2:";
            // 
            // lbValor1
            // 
            this.lbValor1.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbValor1.ForeColor = System.Drawing.Color.White;
            this.lbValor1.Location = new System.Drawing.Point(42, 79);
            this.lbValor1.Name = "lbValor1";
            this.lbValor1.Size = new System.Drawing.Size(100, 23);
            this.lbValor1.TabIndex = 1;
            this.lbValor1.Text = "Valor 1:";
            // 
            // Multiplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Multiplicacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multiplicação de Três Numeros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.Label lbOperacao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbValor2;
        private System.Windows.Forms.Label lbValor1;
        private System.Windows.Forms.Label lbOperacao1;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label lbValor3;
    }
}

