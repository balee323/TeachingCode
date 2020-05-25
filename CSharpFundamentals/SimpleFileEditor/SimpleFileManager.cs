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


        //public List<string> LoadTextFileAsLines()
        //{
        //    //you can create a list from an array and vice-versa
        //    //list.ToArray()
        //    //array.ToList()

        //    List<string> fileLines = new List<string>(); //for reading in as a list
        //    //string[] fileLine = new string[11];  //for reading in as array

        //    try
        //    {
        //        CheckifFileExists();
        //        //fileLines = File.ReadAllLines(_filePath); //array
        //        fileLines = File.ReadAllLines(_filePath).ToList<string>();  //list
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("An error has occured: " + e);
        //    }


        //    return fileLines;
        //}


        public string[] LoadTextFileAsLines()
        {

            string[] fileLines = new string[11];  //for reading in as array

            try
            {
                CheckifFileExists();
                fileLines = File.ReadAllLines(_filePath); //array
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
