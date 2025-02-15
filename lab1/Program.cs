using System;


namespace Constructor 

{

    class PrintDetails()
    {
        public void printName()
        {
            Console.WriteLine("Prejan Neupane \n 28073/078");

        }
    }

    class PrivateConstructor 
    {
        private string message;
        private PrivateConstructor ()
        {
            this.message = "Hello from private constructor class ";
            Console.WriteLine("Private constructor run with message " + message);
        }
        // factory method to create an instance 
        public static PrivateConstructor CreateInstance()
        {
            return new PrivateConstructor();

        }
    }
    class Lab1
    {

        private static string msg ;

        
        private string message ;

        static Lab1()
        {
            msg = "static constructor is called";
            Console.WriteLine(Lab1.msg);
        }

        // declearing copy constructor 

        public Lab1 (Lab1 obj)
        {
            this.message = obj.message;
            Console.WriteLine("Copy constructor run with message "+ this.message);
        }
        // default constructor 
        Lab1()
        {
            message = "Hello" ;
            Console.WriteLine("default constructor called");
            
        }
        // parameterized constructor 
        public Lab1(string message)
        {
            this.message = message;
            Console.WriteLine("Parameterized constructor run with the message " + this.message);
            
        }


        public static void Main(string[] args)
        {
            Lab1 obj1 = new Lab1();
            Lab1 obj2 = new Lab1("Hi");
            Lab1 obj3 = new Lab1(obj2);
            PrivateConstructor obj4 = PrivateConstructor.CreateInstance();

            PrintDetails name = new PrintDetails();
            name.printName();

        }

    }
}