using System;
using System.IO;


namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("example.txt");
            Console.WriteLine("Enter any text :");
            string str = Console.ReadLine();

            sw.WriteLine(str); //Write into the buffer
            sw.Flush();
            sw.Close();

            StreamReader sr = new StreamReader("hello.txt");

            sr.BaseStream.Seek(0,SeekOrigin.Begin); //move file pointer to the begining of the file 
            string text = sr.ReadLine(); 

            while (text!=null)
            {
                Console.WriteLine(text);
                text=sr.ReadLine();
            }

            sr.Close();



        }
    }
}