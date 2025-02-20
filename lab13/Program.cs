using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] languages = {"C#", "VB", "Java", "C++","C", "Perl", "Ruby", "Python"}; 

            var result = from language in languages
                        where language.Contains('C')
                        select language;


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Prejan Neupane\n28073/078");
        }
    }
}