using System;

namespace Indexer 
{
    class Lab4a
    {
        private string[] names = new string[4];

        public string this[int x]
        {
            get
            {
                return names[x];
            }
            set 
            {
                names[x]=value;
            }

        }
    }

    class Lab4b
    {
        private Dictionary <string, int> dict = new Dictionary <string, int>();

        public int this[string x]
        {
            get
            {
                if (dict.ContainsKey(x))
                {
                    return dict[x];
                }
                else
                {
                    throw new KeyNotFoundException("Student not found");
                }
            }
            set 
            {
                dict[x]= value;
            }
        }

        static void Main(string[] args)
        {
            Lab4a student = new Lab4a();

            student[0] = "abc";
            student[1] = "bcd";
            student[2] = "cda";
            student[3] = "xyz";


            for (int i =0; i<4;i++)
            {
                Console.WriteLine(student[i]);
            }


            Lab4b obj = new Lab4b();


            obj["science"] = 40;
            obj["math"] = 90;

            Console.WriteLine("Scince: "+obj["science"]);
            Console.WriteLine("Math: "+obj["math"]);

            Console.WriteLine("Prejan Neupane \n28073/078");

        }
    }
}