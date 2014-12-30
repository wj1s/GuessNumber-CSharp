using System.Linq;
using GuessNumber.RandomSeed;

namespace GuessNumber
{
    public class NumberGenerate
    {
        private readonly IRandomSeed randomSeed;

        public NumberGenerate(IRandomSeed randomSeed)
        {
            this.randomSeed = randomSeed;
        }

        public string Generate()
        {
            while (true)
            {
                var number = randomSeed.GenerateRandomSeed().ToString();
                if (!IsDuplication(number))
                {
                    return number.Length == 3 ? "0" + number : number;
                }
            }
        }

        private static bool IsDuplication(string number)
        {
            var dup = number.Distinct().Count() != number.Count();
            var lessThan1000AndHave0 = number.Length == 3 && number.Contains("0");
            return dup || lessThan1000AndHave0;
        }
    }
}