using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Rules
{
    public class FileManager
    {
        private OpenFileDialog fileDialog;
        private bool fileOpen;
        public String absolutePath
        {
            get
            {
                if (fileDialog == null || !fileOpen)
                {
                    throw new FileNotFoundException("Nenhum arquivo aberto");
                }
                FileInfo fileInfo = new FileInfo(fileDialog.FileName);
                return fileInfo.DirectoryName + "\\" + fileInfo.Name;
            }
        }

        public String fileContent
        {
            get
            {
                if (fileDialog == null || !fileOpen)
                {
                    throw new FileNotFoundException("Nenhum arquivo aberto");
                }
                var sr = new StreamReader(fileDialog.FileName);
                return sr.ReadToEnd();
            }
        }

        public FileManager()
        {
            fileOpen = false;
        }
       
        public bool OpenFile()
        {
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Text|*.txt";

                fileOpen = fileDialog.ShowDialog() == DialogResult.OK;

                return fileOpen;

            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Não foi possível abrir o arquivo. Erro: {0}", e.ToString()));
                return false;

            }
        }
        
        //TO DO IMPLEMENT
        public void SaveFile()
        {
            if (!fileOpen)
            {
                SelectPathToSave();
            }



        }

        public void SelectPathToSave()
        {
        }

        public void Save()
        {



        }
    }
}



