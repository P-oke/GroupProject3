using System;
using System.IO;
using System.Collections.Generic;

namespace GroupProject
{
    public class Document
    {
        private string folderPath;
        private string filePath;

        public Document()
        {
            this.folderPath = "fifa";
            this.filePath = @"fifa\worldcupwinners.txt";

        }


        public void CreateFolder()
        {

            {
                if (Directory.Exists(folderPath))
                {
                    Console.WriteLine("The folder path already exists.");
                    return;
                }
                else
                {
                    Directory.CreateDirectory(filePath);
                    Console.WriteLine("The folder was created successfully.");
                }

            }

        }

        public void WriteToTextFile()
        {

            List<string> textFileInput = new List<string>();
            textFileInput.Add("Country\t\t\t WinningYear");
            textFileInput.Add("Brazil\t\t\t 2002");
            textFileInput.Add("Italy\t\t\t 2006");
            textFileInput.Add("Spain\t\t\t 2010");
            textFileInput.Add("Germany\t\t\t 2014");

            Console.WriteLine("You have successfully written to the file.");

            File.WriteAllLines(filePath, textFileInput);

        }

        public void ReadFromTextFile()
        {

            string[] contentsInTextFile = File.ReadAllLines(filePath);

            foreach (string eachContent in contentsInTextFile)
            {
                Console.WriteLine(eachContent);

            }

        }
    }


}