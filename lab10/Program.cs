using System;
using System.Collections;//non generic collections 
using System.Collections.Generic;


namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nongen = new ArrayList();
            nongen.Add(10);
            nongen.Add(20);
            nongen.Add("Hello");
            nongen.Add(3.5);

            Console.WriteLine("<---Non generic collection (ArrayList)");
            foreach (var item in nongen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("<----Generic collection (List)------->");

            List<int> list = new List<int>();
            list.Add(20);
            list.Add(11);
            list.Add(0);

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            
        }
    }
}