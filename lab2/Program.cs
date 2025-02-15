using System ;


namespace Property
{

    class PrintDetails()
    {
        public void printName()
        {
            Console.WriteLine("Prejan Neupane \n28073/078");

        }
    }

    class AutoProperty
    {

        public string Name {get; set;}

        public AutoProperty(string name)
        {
            this.Name = name ;
        }
        

    }
    class ReadOnlyProperty
    {
        public  string Name {get; }

        // read only property 
       
        // constructor 
        public ReadOnlyProperty(string name)
        {
            this.Name = name;
        }
        public static void Main(string[] args)
        {
            ReadOnlyProperty obj1 = new ReadOnlyProperty("Prejan");
            Console.WriteLine(obj1.Name);
            AutoProperty obj2 = new AutoProperty("Prejan");
            Console.WriteLine(obj2.Name);
            obj2.Name = "Hello";
            Console.WriteLine(obj2.Name);

            PrintDetails name = new PrintDetails();
            name.printName();

        
        }
    }
    

}
