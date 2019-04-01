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
        public string filePath { get;set;}
        public string fileContent
        {
            get
            {  
                if (!FileOpenExists())
                {
                    throw new FileNotFoundException("Nenhum arquivo aberto");
                }
                StreamReader streamReader = new StreamReader(filePath);
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
                filePath = openFileDialog.FileName;
                return true;
            }

            return false;
        }
        
        public void SaveFile(String fileText)
        {
            if (FileOpenExists())
            {
                WriteFile(filePath, fileText);
            }
            else
            {
                string path = SelectPathToSave();
                CreateFile(path);
                WriteFile(path, fileText);
                filePath = path;
            }
        }

        private bool FileOpenExists()
        {
            return File.Exists(filePath);
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
            File.Create(path).Close();
        }
    }
}



