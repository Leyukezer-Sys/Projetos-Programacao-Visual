namespace FormsAppSimuladorAluno
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
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAprovarExame = new System.Windows.Forms.Button();
            this.btMediaFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.BackColor = System.Drawing.Color.Bisque;
            this.btSimularMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSimularMedia.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularMedia.Location = new System.Drawing.Point(12, 83);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(460, 75);
            this.btSimularMedia.TabIndex = 0;
            this.btSimularMedia.Text = "SIMULAR MÉDIA";
            this.btSimularMedia.UseVisualStyleBackColor = false;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAprovarExame
            // 
            this.btAprovarExame.BackColor = System.Drawing.Color.GhostWhite;
            this.btAprovarExame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAprovarExame.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAprovarExame.Location = new System.Drawing.Point(12, 181);
            this.btAprovarExame.Name = "btAprovarExame";
            this.btAprovarExame.Size = new System.Drawing.Size(460, 75);
            this.btAprovarExame.TabIndex = 2;
            this.btAprovarExame.Text = "NOTA MÍNIMA PARA SER APROVADO NO EXAME";
            this.btAprovarExame.UseVisualStyleBackColor = false;
            this.btAprovarExame.Click += new System.EventHandler(this.btAprovarExame_Click);
            // 
            // btMediaFinal
            // 
            this.btMediaFinal.BackColor = System.Drawing.Color.PowderBlue;
            this.btMediaFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMediaFinal.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMediaFinal.Location = new System.Drawing.Point(12, 274);
            this.btMediaFinal.Name = "btMediaFinal";
            this.btMediaFinal.Size = new System.Drawing.Size(460, 75);
            this.btMediaFinal.TabIndex = 3;
            this.btMediaFinal.Text = "VERIFICAR A MÉDIA FINAL APÓS A NOTA DO EXAME FINAL";
            this.btMediaFinal.UseVisualStyleBackColor = false;
            this.btMediaFinal.Click += new System.EventHandler(this.btMediaFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btMediaFinal);
            this.Controls.Add(this.btAprovarExame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSimularMedia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "============ HOME ============";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAprovarExame;
        private System.Windows.Forms.Button btMediaFinal;
    }
}

