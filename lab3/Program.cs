using System ;

namespace lab3
{
    class PrintDetails()
    {
        public void printName()
        {
            Console.WriteLine("Prejan Neupane \n28073/078");

        }
    }

    class JaggedArray
    {
        public static void Main(string[] args )
        {
            int [][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] {3,2,1};
            jaggedArray[1] = new int[]{1,2,3,4,5,6,7};
            jaggedArray[2] = new int[]{0,3,5,4,2};

            for (int i = 0; i<jaggedArray.Length; i++)
            {
                foreach(int num in jaggedArray[i])
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            PrintDetails name = new PrintDetails();
            name.printName();
        }
    }
}
