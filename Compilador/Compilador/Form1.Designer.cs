namespace Compilador
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
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // scintilla1
            // 
            this.scintilla1.Location = new System.Drawing.Point(366, 121);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(341, 243);
            this.scintilla1.TabIndex = 0;
            this.scintilla1.Text = "scintilla1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scintilla1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.scintilla1.Margins[0].Width = 16;


        }

        #endregion

        private ScintillaNET.Scintilla scintilla1;
    }
}

