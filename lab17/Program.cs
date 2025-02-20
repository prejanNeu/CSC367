using System ;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Ordering Food");

            string food = await OrderFood();
            Console.WriteLine(food);
            Console.WriteLine("Watching TV while waiting ...");

            Console.WriteLine("Prejan Neupane\n28073/078");

        }
        static async Task<string> OrderFood()
        {
            await Task.Delay(3000);
            return "food is ready";
        }
    }
}