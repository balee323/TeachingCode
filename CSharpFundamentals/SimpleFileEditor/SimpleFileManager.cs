using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleFileEditor
{
    class SimpleFileManager
    {

        private string _filePath;

        public SimpleFileManager(string filePath)
        {
            _filePath = filePath;
        }


        public List<string> LoadTextFileAsLines()
        {
            // List<string> fileLines = new List<string>();
            string[] fileLines = new string[11];

            try
            {
                CheckifFileExists();
                fileLines = File.ReadAllLines(_filePath);  // .ToList<string>();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured: " + e);
            }


            return fileLines;
        }


        public string LoadTextFileAsSingleString()
        {
            string fileContent = string.Empty;

            try
            {
                //throw new Exception("Hey chris.. somethin bad...!");

                fileContent = File.ReadAllText(_filePath);

            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured: " + e);               
            }

            return fileContent;
        }


        public void SaveFile(string fileContent)
        {
            try
            {
                CheckifFileExists();
                File.WriteAllText(_filePath, fileContent);
               
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured: " + e);
            }
        }


        private void CheckifFileExists()
        {
            FileInfo fileInfo = new FileInfo(_filePath);

            if (!fileInfo.Exists)
            {
                Console.WriteLine("File does not exist, creating file.");
                fileInfo.Create();
            }

        }



    }
}
