namespace FormsAppSimuladorAluno.Formularios
{
    partial class FormSimuladorExame
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
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbResposta = new System.Windows.Forms.Label();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularMedia.Location = new System.Drawing.Point(54, 232);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(149, 45);
            this.btSimularMedia.TabIndex = 17;
            this.btSimularMedia.Text = "SIMULAR";
            this.btSimularMedia.UseVisualStyleBackColor = true;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(45, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 28);
            this.txtNome.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label5.Location = new System.Drawing.Point(41, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome do Acadêmico:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbResposta
            // 
            this.lbResposta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResposta.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.Location = new System.Drawing.Point(0, 301);
            this.lbResposta.Margin = new System.Windows.Forms.Padding(0);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbResposta.Size = new System.Drawing.Size(484, 60);
            this.lbResposta.TabIndex = 15;
            this.lbResposta.Text = "...";
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtMediaFinal.Location = new System.Drawing.Point(180, 183);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(115, 28);
            this.txtMediaFinal.TabIndex = 14;
            this.txtMediaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label2.Location = new System.Drawing.Point(163, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Média Final:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 62);
            this.label1.TabIndex = 12;
            this.label1.Text = "SIMULADOR DE NOTA MÍNIMA PARA APROVAÇÃO EXAME FINAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "NOVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSimuladorExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSimularMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.txtMediaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimuladorExame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "============ EXAME FINAL ============";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.TextBox txtMediaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}