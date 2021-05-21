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

            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("The folder path already exists.");
                return;
            }
            else
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("The folder was created successfully.");
            }


        }

        public void WriteToTextFile()
        {

            string[] countries = new[]{"Uruguay", "Italy", "Italy", "Uruguay", "West Germany",
                                    "Brazil", "Brazil", "England", "Brazil", "West Germany",
                                    "Argentina", "Italy", "Argentina", "West Germany", "Brazil",
                                    "France", "Brazil", "Italy", "Spain", "Germany", "France"};

            string[] year = new[]{"1930", "1934", "1938", "1950", "1954",
                                    "1958", "1962", "1966", "1970", "1974",
                                    "1978", "1982", "1986", "1990", "1994",
                                    "1998", "2002", "2006", "2010", "2014", "2018"};

            List<string> textFileInput = new List<string>();

            textFileInput.Add("WinningYear\t\tCountry");
            for (int i = 0; i < countries.Length; i++)
            {

                textFileInput.Add($"{year[i]}\t\t\t {countries[i]}");

            }

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