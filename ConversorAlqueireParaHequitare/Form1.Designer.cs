namespace ConversorAlqueireParaHequitare
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
            this.txtHectare = new System.Windows.Forms.TextBox();
            this.txtAlqueirePaulista = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btConverter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHectare
            // 
            this.txtHectare.Font = new System.Drawing.Font("Miriam Mono CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHectare.Location = new System.Drawing.Point(131, 372);
            this.txtHectare.Name = "txtHectare";
            this.txtHectare.Size = new System.Drawing.Size(230, 37);
            this.txtHectare.TabIndex = 13;
            // 
            // txtAlqueirePaulista
            // 
            this.txtAlqueirePaulista.Font = new System.Drawing.Font("Miriam Mono CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAlqueirePaulista.Location = new System.Drawing.Point(131, 199);
            this.txtAlqueirePaulista.Name = "txtAlqueirePaulista";
            this.txtAlqueirePaulista.Size = new System.Drawing.Size(230, 37);
            this.txtAlqueirePaulista.TabIndex = 12;
            this.txtAlqueirePaulista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlqueirePaulista_KeyDown);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F);
            this.btNovo.Location = new System.Drawing.Point(452, 276);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(195, 39);
            this.btNovo.TabIndex = 11;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btConverter
            // 
            this.btConverter.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F);
            this.btConverter.Location = new System.Drawing.Point(131, 276);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(195, 39);
            this.btConverter.TabIndex = 10;
            this.btConverter.Text = "CONVERTER";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(127, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hectare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(127, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Informe o Alqueire Paulista:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Miriam Mono CLM", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Converter Alqueire Paulista em Hectares";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHectare);
            this.Controls.Add(this.txtAlqueirePaulista);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "2º Período ADS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHectare;
        private System.Windows.Forms.TextBox txtAlqueirePaulista;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

