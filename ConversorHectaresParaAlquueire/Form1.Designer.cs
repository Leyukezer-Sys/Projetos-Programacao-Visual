namespace ConversorHectaresParaAlquueire
{
    partial class Form_Convert_Hec_Alq
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btConverter = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtHectare = new System.Windows.Forms.TextBox();
            this.txtAlqueire = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Converter Hectares em Alqueire Paulista";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(127, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe o Hectare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(127, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alqueire:";
            // 
            // btConverter
            // 
            this.btConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btConverter.Location = new System.Drawing.Point(131, 234);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(195, 39);
            this.btConverter.TabIndex = 3;
            this.btConverter.Text = "CONVERTER";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btNovo.Location = new System.Drawing.Point(452, 234);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(195, 39);
            this.btNovo.TabIndex = 4;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // txtHectare
            // 
            this.txtHectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHectare.Location = new System.Drawing.Point(131, 157);
            this.txtHectare.Name = "txtHectare";
            this.txtHectare.Size = new System.Drawing.Size(230, 35);
            this.txtHectare.TabIndex = 5;
            this.txtHectare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHectare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHectare_KeyDown);
            // 
            // txtAlqueire
            // 
            this.txtAlqueire.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAlqueire.Location = new System.Drawing.Point(131, 330);
            this.txtAlqueire.Name = "txtAlqueire";
            this.txtAlqueire.Size = new System.Drawing.Size(230, 35);
            this.txtAlqueire.TabIndex = 6;
            this.txtAlqueire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Convert_Hec_Alq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAlqueire);
            this.Controls.Add(this.txtHectare);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Convert_Hec_Alq";
            this.ShowIcon = false;
            this.Text = "2º Periodo ADS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox txtHectare;
        private System.Windows.Forms.TextBox txtAlqueire;
    }
}

