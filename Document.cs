using System;
using System.IO;
using System.Collections.Generic;

namespace GroupProject
{
    public class Document
    {
        private string Folderpath;
        private string Filepath;

        public Document()
        {
            this.Folderpath = @"C:\Users\Hp\Desktop\GroupProject\fifa";
            this.Filepath = @"C:\Users\Hp\Desktop\GroupProject\fifa\worldcupwinners.txt";

        }


        public void createFolder()
        {

            {
                if (Directory.Exists(Folderpath))
                {
                    Console.WriteLine("The folder path already exists.");
                    return;
                }
                else
                {
                    Directory.CreateDirectory(Folderpath);
                    Console.WriteLine("The folder was created successfully.");
                }

            }


        }

        public void writeToTextFile()
        {


            List<string> addTextToFile = new List<string>();
            addTextToFile.Add("Country\t\t\t WinningYear");
            addTextToFile.Add("Brazil\t\t\t 2002");
            addTextToFile.Add("Italy\t\t\t 2006");
            addTextToFile.Add("Spain\t\t\t 2010");
            addTextToFile.Add("Germany\t\t\t 2014");

            Console.WriteLine("You have successfully written to the file.");

            File.WriteAllLines(Filepath, addTextToFile);


        }

        public void readFromTextFile()
        {

            string[] contentsInText = File.ReadAllLines(Filepath);

            foreach (string eachContent in contentsInText)
            {
                Console.WriteLine(eachContent);

            }

        }
    }


}