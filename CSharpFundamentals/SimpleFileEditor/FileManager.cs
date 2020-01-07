using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace SimpleFileEditor
{
    class FileManager
    {

        public FileManager(string fileName, string directory)
        {
            FileName = fileName;
            Directory = directory;
        }

        public string FileName { get; set; }
        public string Directory { get; set; }

        public string ViewFile()
        {
            var fs = GetFileStream();

            if(fs == null)
            {
                Console.WriteLine("No file selected");
                return string.Empty;
            }


            byte[] rawData = new byte[fs.Length - 1];
            fs.Read(rawData, 0, 0);

            fs.Close();

            Console.WriteLine(rawData);

            var stringUTF8 = Encoding.UTF8.GetString(rawData, 0, rawData.Length);

            var stringASCII = Encoding.ASCII.GetString(rawData, 0, rawData.Length);


            return stringASCII;
        }


        public void WriteFile(string data)
        {
            var fs = GetFileStream();

            byte[] buffer = Encoding.ASCII.GetBytes(data);

            BitArray bits = new BitArray(buffer);

            string bitString = string.Empty;
            var tempString = string.Empty;

            for(int i = 0; i < bits.Length; i++)
            {
                var singleBit = (bits[i] ? "1" : "0"); //set true/false to 1 or 0
                tempString = singleBit + tempString;        
                //show 8 bit groups
                if ((i + 1) % 8 == 0)
                {
                    bitString = bitString + tempString + " ";
                    tempString = string.Empty;
                }                  
            }

            Console.WriteLine(bitString);


            //Console.WriteLine("here's the raw data that will be written: \r\n");
            //var sb = new StringBuilder("new byte[] { ");

            //foreach (var b in buffer)
            //{            
            //        sb.Append(b + ", ");                              
            //}

            //sb = sb.Remove(sb.Length - 2, 2); //cut out the trailing comma

            //sb.Append("}");
            //Console.WriteLine(sb.ToString());


            fs.Write(buffer, 0, data.Length);

            fs.Close();
        }


        private FileStream GetFileStream()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Directory);

            string path = Directory + FileName;

            if (directoryInfo.Exists)
            {
                if (File.Exists(path)){
                    FileStream fs = new FileStream(path, FileMode.Open);
                    return fs;
                }
                else
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    return fs;
                }           
            }
            else
            {
                Console.WriteLine("directory does not exist \r\n");

                Console.WriteLine("Shall we create the directory? Press Y to create. \r\n");

                string decision = Console.ReadKey().KeyChar.ToString();

                if(decision.ToLower() == "y")
                {
                    directoryInfo.Create();

                }

                return null;
            }
        }






    }
}
