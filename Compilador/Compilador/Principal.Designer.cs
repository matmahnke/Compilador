namespace Compilador
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.Button btnCompilar;
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnColar = new System.Windows.Forms.Button();
            this.btnRecortar = new System.Windows.Forms.Button();
            this.editor = new ScintillaNET.Scintilla();
            this.mesagens = new System.Windows.Forms.RichTextBox();
            this.barraStatus = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            btnCompilar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEquipe
            // 
            this.btnEquipe.AutoSize = true;
            this.btnEquipe.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipe.Image")));
            this.btnEquipe.Location = new System.Drawing.Point(786, 3);
            this.btnEquipe.MinimumSize = new System.Drawing.Size(105, 70);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(105, 70);
            this.btnEquipe.TabIndex = 2;
            this.btnEquipe.Text = "equipe [F1]";
            this.btnEquipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEquipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEquipe.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(9, 3);
            this.btnNovo.MinimumSize = new System.Drawing.Size(105, 70);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 70);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "novo [ctrl-n]";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.AutoSize = true;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(120, 3);
            this.btnAbrir.MinimumSize = new System.Drawing.Size(105, 70);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(105, 70);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "abrir [ctrl-o]";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(231, 3);
            this.btnSalvar.MaximumSize = new System.Drawing.Size(0, 70);
            this.btnSalvar.MinimumSize = new System.Drawing.Size(105, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 70);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "salvar [ctrl-s]";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiar.Image")));
            this.btnCopiar.Location = new System.Drawing.Point(342, 3);
            this.btnCopiar.MinimumSize = new System.Drawing.Size(105, 70);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(105, 70);
            this.btnCopiar.TabIndex = 11;
            this.btnCopiar.Text = "copiar [ctrl-c]";
            this.btnCopiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // btnColar
            // 
            this.btnColar.Image = ((System.Drawing.Image)(resources.GetObject("btnColar.Image")));
            this.btnColar.Location = new System.Drawing.Point(453, 3);
            this.btnColar.MinimumSize = new System.Drawing.Size(105, 70);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(105, 70);
            this.btnColar.TabIndex = 12;
            this.btnColar.Text = "colar [ctrl-v]";
            this.btnColar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnColar.UseVisualStyleBackColor = true;
            // 
            // btnRecortar
            // 
            this.btnRecortar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecortar.Image")));
            this.btnRecortar.Location = new System.Drawing.Point(564, 3);
            this.btnRecortar.MinimumSize = new System.Drawing.Size(105, 70);
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(105, 70);
            this.btnRecortar.TabIndex = 13;
            this.btnRecortar.Text = "recortar [ctrl-x]";
            this.btnRecortar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecortar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecortar.UseVisualStyleBackColor = true;
            // 
            // btnCompilar
            // 
            btnCompilar.AutoSize = true;
            btnCompilar.Image = ((System.Drawing.Image)(resources.GetObject("btnCompilar.Image")));
            btnCompilar.Location = new System.Drawing.Point(675, 3);
            btnCompilar.MinimumSize = new System.Drawing.Size(105, 70);
            btnCompilar.Name = "btnCompilar";
            btnCompilar.Size = new System.Drawing.Size(105, 70);
            btnCompilar.TabIndex = 14;
            btnCompilar.Text = "compilar [F9]";
            btnCompilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCompilar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCompilar.UseVisualStyleBackColor = true;
            // 
            // editor
            // 
            this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editor.Location = new System.Drawing.Point(3, 80);
            this.editor.MinimumSize = new System.Drawing.Size(900, 350);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(900, 350);
            this.editor.TabIndex = 15;
            this.editor.Text = "scintilla1";
            this.editor.Click += new System.EventHandler(this.editor_Click);
            this.editor.Margins[0].Width = 16;
            // 
            // mesagens
            // 
            this.mesagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mesagens.AutoSize = true;
            this.mesagens.Location = new System.Drawing.Point(3, 435);
            this.mesagens.MinimumSize = new System.Drawing.Size(900, 85);
            this.mesagens.Name = "mesagens";
            this.mesagens.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.mesagens.Size = new System.Drawing.Size(900, 218);
            this.mesagens.TabIndex = 16;
            this.mesagens.Text = "";
            this.mesagens.WordWrap = false;
            // 
            // barraStatus
            // 
            this.barraStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraStatus.Location = new System.Drawing.Point(3, 659);
            this.barraStatus.MinimumSize = new System.Drawing.Size(900, 30);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.ReadOnly = true;
            this.barraStatus.Size = new System.Drawing.Size(900, 30);
            this.barraStatus.TabIndex = 17;
            this.barraStatus.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCopiar);
            this.panel1.Controls.Add(this.btnEquipe);
            this.panel1.Controls.Add(btnCompilar);
            this.panel1.Controls.Add(this.btnRecortar);
            this.panel1.Controls.Add(this.btnColar);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.MinimumSize = new System.Drawing.Size(900, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 77);
            this.panel1.TabIndex = 18;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mesagens);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.editor);
            this.MinimumSize = new System.Drawing.Size(922, 600);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnRecortar;
        private ScintillaNET.Scintilla editor;
        private System.Windows.Forms.RichTextBox mesagens;
        private System.Windows.Forms.RichTextBox barraStatus;
        private System.Windows.Forms.Panel panel1;
    }
}