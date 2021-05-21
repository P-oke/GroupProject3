using System;


namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            try
            {
                document.createFolder();
                document.writeToTextFile();
                document.readFromTextFile();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }




        }
    }
}

