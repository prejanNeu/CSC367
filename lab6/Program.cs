

using System ;

namespace Lab6
{
    class Parent
    {
        public void display()
        {
            Console.WriteLine("Parent class");
        }
        public virtual void show()
        {
            Console.WriteLine("Parent class");

        }

    }
    class Child:Parent
    {
        // hiding or shadowing uing new keyword
        public new void display()
        {
            Console.WriteLine("Child Class");
        }

        public override void show()
        {
            Console.WriteLine("Child Class");

        }

        static void Main(string[] args )
        {
            Parent po = new Parent();
            Child co = new Child();
            Parent pc = new Child();

            Console.WriteLine("Hiding or shadowing example :");
            po.display();
            co.display();
            pc.display();

            Console.WriteLine("Function overriding example :");
            po.show();
            co.show();
            pc.show();

            Console.WriteLine("Prejan Neupane\t28073/078");
            
        }

    }
}