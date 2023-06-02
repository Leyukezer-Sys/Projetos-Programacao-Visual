namespace AppFormTemp.Formularios
{
    partial class FormSinais
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
            this.components = new System.ComponentModel.Container();
            this.btVerde = new System.Windows.Forms.Button();
            this.btAmarelo = new System.Windows.Forms.Button();
            this.btVermelho = new System.Windows.Forms.Button();
            this.timerVerde = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btVerde
            // 
            this.btVerde.Location = new System.Drawing.Point(49, 70);
            this.btVerde.Name = "btVerde";
            this.btVerde.Size = new System.Drawing.Size(224, 317);
            this.btVerde.TabIndex = 0;
            this.btVerde.UseVisualStyleBackColor = true;
            // 
            // btAmarelo
            // 
            this.btAmarelo.Location = new System.Drawing.Point(293, 67);
            this.btAmarelo.Name = "btAmarelo";
            this.btAmarelo.Size = new System.Drawing.Size(224, 317);
            this.btAmarelo.TabIndex = 1;
            this.btAmarelo.UseVisualStyleBackColor = true;
            // 
            // btVermelho
            // 
            this.btVermelho.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVermelho.Location = new System.Drawing.Point(540, 67);
            this.btVermelho.Name = "btVermelho";
            this.btVermelho.Size = new System.Drawing.Size(224, 317);
            this.btVermelho.TabIndex = 2;
            this.btVermelho.UseVisualStyleBackColor = true;
            // 
            // timerVerde
            // 
            this.timerVerde.Interval = 400;
            this.timerVerde.Tick += new System.EventHandler(this.timerVerde_Tick);
            // 
            // FormSinais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVermelho);
            this.Controls.Add(this.btAmarelo);
            this.Controls.Add(this.btVerde);
            this.Name = "FormSinais";
            this.Text = "FormSinais";
            this.Load += new System.EventHandler(this.FormSinais_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVerde;
        private System.Windows.Forms.Button btAmarelo;
        private System.Windows.Forms.Button btVermelho;
        private System.Windows.Forms.Timer timerVerde;
    }
}