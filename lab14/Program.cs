using System;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            // lambda expression 

            Console.WriteLine("<------lambda expression ------->");
            
            Func<int, int> square = x=>x*x;
            Console.WriteLine(square(3));

            // lambda expression with multiple parameter 

            Func<int,int,int> sum = (a,b)=>a+b;
            Console.WriteLine(sum(3,4));

            // lambda expression with LINQ 

            Console.WriteLine("<-------Lambda expression with Linq------>");

            List<int> nums = new List<int>{1,2,3,4,5,6,7,8,9,10};
            var evennums = nums.Where(n=>n%2==0);

            foreach (var evennum in evennums)
            {
                Console.WriteLine(evennum);
            }

        }
    }
}