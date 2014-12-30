using GuessNumber.CustomConsole;
using GuessNumber.RandomSeed;

namespace GuessNumber
{
    public class Program
    {
        public static IRandomSeed RandomSeedGenerate = new RandomSeedGenerate();
        public static IConsole Console = new CustomConsole.CustomConsole();

        public static void Main()
        {
            var generate = new NumberGenerate(RandomSeedGenerate).Generate(); ;
            var compare="";
            while (!compare.Equals("4A0B"))
            {
                Console.WriteLine("please input a number:");
                var readLine = Console.ReadLine();
                compare = NumberCompare.Compare(generate, readLine);
                Console.WriteLine(compare);
            }
        }
    }
}
