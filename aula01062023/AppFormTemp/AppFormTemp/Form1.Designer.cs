namespace AppFormTemp
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
            this.components = new System.ComponentModel.Container();
            this.btComecar = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.timerPrimeiroTeste = new System.Windows.Forms.Timer(this.components);
            this.btSinaleiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btComecar
            // 
            this.btComecar.BackColor = System.Drawing.Color.Black;
            this.btComecar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComecar.ForeColor = System.Drawing.Color.Transparent;
            this.btComecar.Location = new System.Drawing.Point(12, 58);
            this.btComecar.Name = "btComecar";
            this.btComecar.Size = new System.Drawing.Size(343, 60);
            this.btComecar.TabIndex = 0;
            this.btComecar.Text = "COMEÇAR";
            this.btComecar.UseVisualStyleBackColor = false;
            this.btComecar.Click += new System.EventHandler(this.btComecar_Click);
            // 
            // btParar
            // 
            this.btParar.BackColor = System.Drawing.Color.Black;
            this.btParar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParar.ForeColor = System.Drawing.Color.Transparent;
            this.btParar.Location = new System.Drawing.Point(457, 58);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(331, 60);
            this.btParar.TabIndex = 1;
            this.btParar.Text = "PARAR";
            this.btParar.UseVisualStyleBackColor = false;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // timerPrimeiroTeste
            // 
            this.timerPrimeiroTeste.Interval = 150;
            this.timerPrimeiroTeste.Tick += new System.EventHandler(this.timerPrimeiroTeste_Tick);
            // 
            // btSinaleiro
            // 
            this.btSinaleiro.BackColor = System.Drawing.Color.Black;
            this.btSinaleiro.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSinaleiro.ForeColor = System.Drawing.Color.Transparent;
            this.btSinaleiro.Location = new System.Drawing.Point(12, 378);
            this.btSinaleiro.Name = "btSinaleiro";
            this.btSinaleiro.Size = new System.Drawing.Size(331, 60);
            this.btSinaleiro.TabIndex = 2;
            this.btSinaleiro.Text = "SINALEIRO";
            this.btSinaleiro.UseVisualStyleBackColor = false;
            this.btSinaleiro.Click += new System.EventHandler(this.btSinaleiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSinaleiro);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.btComecar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btComecar;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.Timer timerPrimeiroTeste;
        private System.Windows.Forms.Button btSinaleiro;
    }
}

