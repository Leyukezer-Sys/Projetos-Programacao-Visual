namespace ExemplosGrids
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
            this.btFormReajuste = new System.Windows.Forms.Button();
            this.btPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFormReajuste
            // 
            this.btFormReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFormReajuste.Location = new System.Drawing.Point(145, 31);
            this.btFormReajuste.Name = "btFormReajuste";
            this.btFormReajuste.Size = new System.Drawing.Size(501, 68);
            this.btFormReajuste.TabIndex = 0;
            this.btFormReajuste.Text = "TABELA REAJUSTE";
            this.btFormReajuste.UseVisualStyleBackColor = true;
            this.btFormReajuste.Click += new System.EventHandler(this.btFormReajuste_Click);
            // 
            // btPedido
            // 
            this.btPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPedido.Location = new System.Drawing.Point(145, 151);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(501, 68);
            this.btPedido.TabIndex = 1;
            this.btPedido.Text = "TABELA PEDIDO";
            this.btPedido.UseVisualStyleBackColor = true;
            this.btPedido.Click += new System.EventHandler(this.btPedido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPedido);
            this.Controls.Add(this.btFormReajuste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFormReajuste;
        private System.Windows.Forms.Button btPedido;
    }
}

