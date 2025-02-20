using System ;

namespace lab15
{

    class NegativeRollNoException: Exception
    {
        public NegativeRollNoException()
        {
            Console.Write("Exception is occured : The roll no is negative ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("<----Try Catch Finally ----->");
            int i = 0 ;
            int j = 5;
            try
            {
                Console.WriteLine("i / j is :");
                double result = j/i;

                
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            
            finally
            {
                Console.WriteLine("<-----Finally------->");
                Console.Write("i + j is :");
                Console.WriteLine(i+j);

            }

            Console.WriteLine("<------using throw keywrad-------->");

            int a = 0 ;
            int b = 5;
            try
            {
                Console.WriteLine("a / b is :");

                if (a==0)
                {
                    throw new DivideByZeroException();
                }

                double result = b/a;

                
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("<-------Custom Exception -------->");
                int rollno = -1 ;
                if (rollno<0)
                {
                    throw new NegativeRollNoException();
                }
            }

            catch (NegativeRollNoException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}