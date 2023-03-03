namespace ConversorQuilometrosEmMetros
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
            this.txtMetro = new System.Windows.Forms.TextBox();
            this.txtQuilometro = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btConverter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMetro
            // 
            this.txtMetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMetro.Location = new System.Drawing.Point(31, 347);
            this.txtMetro.Name = "txtMetro";
            this.txtMetro.Size = new System.Drawing.Size(230, 35);
            this.txtMetro.TabIndex = 20;
            this.txtMetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuilometro
            // 
            this.txtQuilometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtQuilometro.Location = new System.Drawing.Point(31, 150);
            this.txtQuilometro.Name = "txtQuilometro";
            this.txtQuilometro.Size = new System.Drawing.Size(230, 35);
            this.txtQuilometro.TabIndex = 19;
            this.txtQuilometro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuilometro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuilometro_KeyDown);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btNovo.Location = new System.Drawing.Point(304, 227);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(195, 39);
            this.btNovo.TabIndex = 18;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btConverter
            // 
            this.btConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btConverter.Location = new System.Drawing.Point(31, 227);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(195, 39);
            this.btConverter.TabIndex = 17;
            this.btConverter.Text = "CONVERTER";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(27, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Metro(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Informe o Quilômetro(s):";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "Converter Quilômetros em Metros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.txtMetro);
            this.Controls.Add(this.txtQuilometro);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "2º Periodo ADS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetro;
        private System.Windows.Forms.TextBox txtQuilometro;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

