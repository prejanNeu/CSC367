using System ;

namespace Lab9
{

    class Publisher
    {
        public delegate void Notify();

        public event Notify onCompleted;


        public void Process()
        {
            Console.WriteLine("Processing..........");

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Process Completed!");

            onCompleted?.Invoke();
        }

    }

    class Subscriber
    {
        public void EventHandler()
        {
            Console.WriteLine("Subscriber received the event. ");
        }
    }
    class Rectangle
    {
        public delegate void Calc(int a, int b);

        public delegate void Mul(int a, int b);

        public void Area(int a, int b)
        {
            Console.WriteLine("Area is: "+ a*b);
        }

        public void Perimeter(int a, int b)
        {
            Console.WriteLine("Perimeter is : "+2*(a+b));
        }
        public static int Sum(int a , int b)
        {
            return a+b;
            
        }
        public static void Display(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Calc obj = new Calc(rect.Area);
            obj+=rect.Perimeter;
            obj(3,4); // we can also use obj.Invoke(3,4);

            Console.WriteLine("<----Function Delegate --->");
            Func <int, int, int> Delegate = Sum;

            Console.WriteLine("Function delegete ruturn "+Delegate(5,4));


            Console.WriteLine("<---------Action Delegate---------->");
            Action <string> action = Display;
            action("Hello from action delegate");


            Console.WriteLine("<--------- Anonymous Function --------->");

            Mul m = delegate(int a, int b)
            {
                Console.WriteLine("a*b is " + a*b);
            };
            m(3,4);

            Console.WriteLine("\n<--------Event---------->");
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber();

            pub.onCompleted += sub.EventHandler;
            pub.Process();
        }
    }
}