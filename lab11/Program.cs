using System;

namespace Lab11
{
    public class Generic <T>
    {
        private T data;

        public T value 
        {
            get 
            {
                return this.data;
            }
            set 
            {
                this.data= value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> obj1 = new Generic<int>();
            obj1.value= 20;
            Console.WriteLine(obj1.value);

            Generic<string> obj2 = new Generic<string> ();
            obj2.value= "hello";
            Console.WriteLine(obj2.value);

            Generic<double> obj3 = new Generic<double> ();
            obj3.value= 5.999;
            Console.WriteLine(obj3.value);
            Console.WriteLine("Prejan Neupane\n28073/078");

        }
    }
}