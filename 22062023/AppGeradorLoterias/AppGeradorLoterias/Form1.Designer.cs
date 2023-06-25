namespace AppGeradorLoterias
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
            this.btQuina = new System.Windows.Forms.Button();
            this.btMega = new System.Windows.Forms.Button();
            this.btLotoFacil = new System.Windows.Forms.Button();
            this.btLotomania = new System.Windows.Forms.Button();
            this.btDiaDeSorte = new System.Windows.Forms.Button();
            this.btSuperSete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQuina
            // 
            this.btQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuina.ForeColor = System.Drawing.Color.Blue;
            this.btQuina.Location = new System.Drawing.Point(80, 170);
            this.btQuina.Name = "btQuina";
            this.btQuina.Size = new System.Drawing.Size(179, 42);
            this.btQuina.TabIndex = 29;
            this.btQuina.Text = "QUINA";
            this.btQuina.UseVisualStyleBackColor = true;
            this.btQuina.Click += new System.EventHandler(this.btQuina_Click);
            // 
            // btMega
            // 
            this.btMega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMega.ForeColor = System.Drawing.Color.Green;
            this.btMega.Location = new System.Drawing.Point(80, 81);
            this.btMega.Name = "btMega";
            this.btMega.Size = new System.Drawing.Size(179, 42);
            this.btMega.TabIndex = 28;
            this.btMega.Text = "MEGA SENA";
            this.btMega.UseVisualStyleBackColor = true;
            this.btMega.Click += new System.EventHandler(this.btMega_Click);
            // 
            // btLotoFacil
            // 
            this.btLotoFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLotoFacil.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btLotoFacil.Location = new System.Drawing.Point(429, 81);
            this.btLotoFacil.Name = "btLotoFacil";
            this.btLotoFacil.Size = new System.Drawing.Size(179, 42);
            this.btLotoFacil.TabIndex = 27;
            this.btLotoFacil.Text = "LOTOFÁCIL";
            this.btLotoFacil.UseVisualStyleBackColor = true;
            this.btLotoFacil.Click += new System.EventHandler(this.btLotoFacil_Click);
            // 
            // btLotomania
            // 
            this.btLotomania.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLotomania.ForeColor = System.Drawing.Color.DarkOrange;
            this.btLotomania.Location = new System.Drawing.Point(429, 170);
            this.btLotomania.Name = "btLotomania";
            this.btLotomania.Size = new System.Drawing.Size(179, 42);
            this.btLotomania.TabIndex = 30;
            this.btLotomania.Text = "LOTOMANIA";
            this.btLotomania.UseVisualStyleBackColor = true;
            this.btLotomania.Click += new System.EventHandler(this.btLotomania_Click);
            // 
            // btDiaDeSorte
            // 
            this.btDiaDeSorte.BackColor = System.Drawing.Color.Gainsboro;
            this.btDiaDeSorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiaDeSorte.ForeColor = System.Drawing.Color.Yellow;
            this.btDiaDeSorte.Location = new System.Drawing.Point(80, 280);
            this.btDiaDeSorte.Name = "btDiaDeSorte";
            this.btDiaDeSorte.Size = new System.Drawing.Size(179, 42);
            this.btDiaDeSorte.TabIndex = 31;
            this.btDiaDeSorte.Text = "DIA DE SORTE";
            this.btDiaDeSorte.UseVisualStyleBackColor = false;
            // 
            // btSuperSete
            // 
            this.btSuperSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuperSete.ForeColor = System.Drawing.Color.GreenYellow;
            this.btSuperSete.Location = new System.Drawing.Point(429, 280);
            this.btSuperSete.Name = "btSuperSete";
            this.btSuperSete.Size = new System.Drawing.Size(179, 42);
            this.btSuperSete.TabIndex = 32;
            this.btSuperSete.Text = "SUPER SETE";
            this.btSuperSete.UseVisualStyleBackColor = true;
            this.btSuperSete.Click += new System.EventHandler(this.btSuperSete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(681, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Alunos: Leyukezer Cruz de Lima, Luan Mateus Teofilo de Lima\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSuperSete);
            this.Controls.Add(this.btDiaDeSorte);
            this.Controls.Add(this.btLotomania);
            this.Controls.Add(this.btQuina);
            this.Controls.Add(this.btMega);
            this.Controls.Add(this.btLotoFacil);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORTEIO DE LOTERIA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuina;
        private System.Windows.Forms.Button btMega;
        private System.Windows.Forms.Button btLotoFacil;
        private System.Windows.Forms.Button btLotomania;
        private System.Windows.Forms.Button btDiaDeSorte;
        private System.Windows.Forms.Button btSuperSete;
        private System.Windows.Forms.Label label2;
    }
}

