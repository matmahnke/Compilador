using Rules;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Main
{
    public partial class Principal : Form
    {
        private Team team = new Team();
        private Compiler compiler = new Compiler();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            
        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
       
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = this.editor.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            editor.Margins[0].Width = editor.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            team.Show();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
        

            switch (e.KeyCode.ToString())
            {
                case "F1":
                    team.Show();
                    break;

                case "F9":
                    mensagens.Text = compiler.Compile();
                    break;
                default:
                    break;
            }
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
            mensagens.Text = compiler.Compile();
        }

        private void editor_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            if ((e.Change & UpdateChange.Selection) > 0)
            {
                // The caret/selection changed
                var currentPos = editor.CurrentPosition;
                var anchorPos = editor.AnchorPosition;
                var texto_selecionado = "Ch: " + currentPos + " Sel: " + Math.Abs(anchorPos - currentPos);

                MessageBox.Show(texto_selecionado);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            editor.Copy();
        }

        private void btnColar_Click(object sender, EventArgs e)
        {
            editor.Paste();
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            editor.Cut();
        }
    }
}
