using System.Collections.Generic;
using System.Linq;
using GuessNumber.RandomSeed;

namespace GuessNumber_Test.TestDouble
{
    public class RandomSeedGenerateStub : IRandomSeed
    {
        private readonly IList<int> nums;
        private int count = -1;

        public RandomSeedGenerateStub(IEnumerable<int> num)
        {
            nums = num.ToList();
        }

        public int GenerateRandomSeed()
        {
            count++;
            return nums[count];
        }
    }
}