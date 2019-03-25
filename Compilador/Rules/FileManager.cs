using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Rules
{
    public class FileManager
    {
        private OpenFileDialog openFileDialog;
        public string fileName {get;set;}
        public string fileContent
        {
            get
            {  
                if (!FileOpenExists())
                {
                    throw new FileNotFoundException("Nenhum arquivo aberto");
                }
                StreamReader streamReader = new StreamReader(fileName);
                string text = streamReader.ReadToEnd();
                streamReader.Close();
                return text;
            }
        }
     
        public bool OpenFile()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                return true;
            }

            return false;
        }
        
        public void SaveFile(String fileText)
        {
            if (FileOpenExists())
            {
                WriteFile(fileName, fileText);
            }
            else
            {
                string path = SelectPathToSave();
                CreateFile(path);
                WriteFile(path, fileText);
            }
        }

        private bool FileOpenExists()
        {
            return File.Exists(fileName);
        }

        private void WriteFile(string path, string fileText)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(fileText);
            writer.Close();
        }
        
        private string SelectPathToSave()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return "";
        }

        private void CreateFile(string path)
        {
            var newFile = File.Create(path);
            newFile.Close();
        }
    }
}



