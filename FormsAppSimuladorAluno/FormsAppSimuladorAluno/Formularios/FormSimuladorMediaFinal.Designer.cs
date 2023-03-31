namespace FormsAppSimuladorAluno.Formularios
{
    partial class FormSimuladorMediaFinal
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
            this.button1 = new System.Windows.Forms.Button();
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbResposta = new System.Windows.Forms.Label();
            this.txtExameFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "NOVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularMedia.Location = new System.Drawing.Point(54, 217);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(149, 45);
            this.btSimularMedia.TabIndex = 20;
            this.btSimularMedia.Text = "SIMULAR";
            this.btSimularMedia.UseVisualStyleBackColor = true;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(44, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 28);
            this.txtNome.TabIndex = 12;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label5.Location = new System.Drawing.Point(40, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 34);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nome do Acadêmico:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResposta.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.Location = new System.Drawing.Point(0, 285);
            this.lbResposta.Margin = new System.Windows.Forms.Padding(0);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbResposta.Size = new System.Drawing.Size(484, 76);
            this.lbResposta.TabIndex = 18;
            this.lbResposta.Text = "...";
            // 
            // txtExameFinal
            // 
            this.txtExameFinal.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtExameFinal.Location = new System.Drawing.Point(303, 170);
            this.txtExameFinal.Name = "txtExameFinal";
            this.txtExameFinal.Size = new System.Drawing.Size(115, 28);
            this.txtExameFinal.TabIndex = 17;
            this.txtExameFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label3.Location = new System.Drawing.Point(286, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Exame Final";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtMedia.Location = new System.Drawing.Point(74, 170);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(115, 28);
            this.txtMedia.TabIndex = 15;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Média Acadêmico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 62);
            this.label1.TabIndex = 13;
            this.label1.Text = "SIMULADOR DE MÉDIA FINAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSimuladorMediaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSimularMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.txtExameFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimuladorMediaFinal";
            this.ShowIcon = false;
            this.Text = "============ MÉDIA FINAL ============";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.TextBox txtExameFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}