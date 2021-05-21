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
                document.CreateFolder();
                document.WriteToTextFile();
                document.ReadFromTextFile();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }




        }
    }
}

