using System;
using System.IO;
namespace assignment
{
    public class FileHandling
    {

        public FileHandling()
        {

           
        }
        string filename = "Testfile.txt";

        public void CreateFile()
        {
            File.Create("/Users/present/C#projects/assignment/" + filename);
          
        }
        public void writeFile()
        {
            Console.WriteLine("Insert some string data");
            string Data = Console.ReadLine();
            try
            {
                File.WriteAllText("/Users/present/C#projects/assignment/" + filename, Data);
            }
            catch 
            {

                File.WriteAllText("/Users/present/C#projects/assignment/" + filename, Data);
            }

        }


    }
}
