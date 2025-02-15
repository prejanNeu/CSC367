using System ;

namespace Base
{
    class Parent
    {
        public string name = "HI";

        public Parent(){
            Console.WriteLine("Constructor from Parent class");
        }

        public void Display()
        {
            Console.WriteLine("Hello from parent class ");
        }
    }
    class Child: Parent
    {
        public string name = "Hello";

        public Child():base()
        {
            Console.WriteLine("Constructor from child class");
        }

        public void Show()
        {
            Console.WriteLine("Parent class field is :"+base.name+"\nChild class field is "+ name);
            Console.WriteLine("Hello from child class ");
            base.Display();

            
        }

        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Show();

            Console.WriteLine("Prejan Neupane\n28073/078");
        }

    }
}