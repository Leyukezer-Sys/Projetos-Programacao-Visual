﻿namespace FormsAppSimuladorAluno.Formularios
{
    partial class FormSimuladorMedia
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
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResposta = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIMULADOR DE MÉDIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label2.Location = new System.Drawing.Point(57, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "1ª Nota";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtNota1.Location = new System.Drawing.Point(74, 178);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(115, 28);
            this.txtNota1.TabIndex = 4;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtNota2.Location = new System.Drawing.Point(303, 178);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(115, 28);
            this.txtNota2.TabIndex = 6;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota2_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label3.Location = new System.Drawing.Point(286, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "2ª Nota";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbResposta.TabIndex = 7;
            this.lbResposta.Text = "...";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(45, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 28);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12.25F);
            this.label5.Location = new System.Drawing.Point(41, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do Acadêmico:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularMedia.Location = new System.Drawing.Point(54, 232);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(149, 45);
            this.btSimularMedia.TabIndex = 10;
            this.btSimularMedia.Text = "SIMULAR";
            this.btSimularMedia.UseVisualStyleBackColor = true;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(283, 232);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(149, 45);
            this.btNovo.TabIndex = 11;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormSimuladorMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btSimularMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimuladorMedia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "============ MEDIA ============";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.Button btNovo;
    }
}