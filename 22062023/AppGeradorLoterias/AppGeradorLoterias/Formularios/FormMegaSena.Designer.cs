﻿namespace AppGeradorLoterias.Formularios
{
    partial class FormMegaSena
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbImpar = new System.Windows.Forms.Label();
            this.lbPar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtvNumeros = new System.Windows.Forms.DataGridView();
            this.NÚMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClass
            // 
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbClass.Location = new System.Drawing.Point(82, 258);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(162, 24);
            this.lbClass.TabIndex = 46;
            this.lbClass.Text = "CLASSIFICAÇÃO";
            // 
            // lbImpar
            // 
            this.lbImpar.AutoSize = true;
            this.lbImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpar.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbImpar.Location = new System.Drawing.Point(82, 200);
            this.lbImpar.Name = "lbImpar";
            this.lbImpar.Size = new System.Drawing.Size(89, 20);
            this.lbImpar.TabIndex = 45;
            this.lbImpar.Text = "ÍMPARES";
            // 
            // lbPar
            // 
            this.lbPar.AutoSize = true;
            this.lbPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPar.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbPar.Location = new System.Drawing.Point(82, 158);
            this.lbPar.Name = "lbPar";
            this.lbPar.Size = new System.Drawing.Size(69, 20);
            this.lbPar.TabIndex = 44;
            this.lbPar.Text = "PARES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(155, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "MEGA-SENA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "NÚMEROS DA SORTE";
            // 
            // dtvNumeros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtvNumeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvNumeros.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NÚMERO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvNumeros.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtvNumeros.Location = new System.Drawing.Point(278, 63);
            this.dtvNumeros.Name = "dtvNumeros";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvNumeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtvNumeros.RowHeadersWidth = 51;
            this.dtvNumeros.Size = new System.Drawing.Size(163, 375);
            this.dtvNumeros.TabIndex = 41;
            // 
            // NÚMERO
            // 
            this.NÚMERO.DataPropertyName = "Numero";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NÚMERO.DefaultCellStyle = dataGridViewCellStyle3;
            this.NÚMERO.HeaderText = "NÚMERO";
            this.NÚMERO.MinimumWidth = 6;
            this.NÚMERO.Name = "NÚMERO";
            this.NÚMERO.Width = 125;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(26, 91);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(200, 23);
            this.btLimpar.TabIndex = 40;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(26, 49);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(200, 23);
            this.btGerar.TabIndex = 39;
            this.btGerar.Text = "GERAR NÚMEROS DA SORTE";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // FormMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbImpar);
            this.Controls.Add(this.lbPar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtvNumeros);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btGerar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMegaSena";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEGA SENA";
            ((System.ComponentModel.ISupportInitialize)(this.dtvNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbImpar;
        private System.Windows.Forms.Label lbPar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtvNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn NÚMERO;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btGerar;
    }
}