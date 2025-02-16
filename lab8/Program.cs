using System; 

namespace Lab8
{

    enum Status {Pending,Approved,Rejected}

    public struct Person
    {
        public string name;
        public int age ;
        public int weight;
    }

    public partial class Class1
    {
        public void Show()
        {
            Console.WriteLine("This is from Program.cs file ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("<----------Struct----------->");

            Person p1;
            p1.name = "Ram";
            p1.age = 20;
            p1.weight = 60 ;

            Console.WriteLine(p1.name + " is "+p1.age+" years old and he is "+p1.weight +" kg.");

            Console.WriteLine("\n<----------Enum------------->");


            Status s = Status.Rejected;
            Console.WriteLine(s);
            Console.WriteLine((int)s);


            Console.WriteLine("\n<------------Partial Class ----------->");

            Class1 obj = new Class1();
            obj.Display();
            obj.Show();

        }
    }

}
