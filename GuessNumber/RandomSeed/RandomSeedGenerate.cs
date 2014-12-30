using System;

namespace GuessNumber.RandomSeed
{
    public class RandomSeedGenerate : IRandomSeed
    {
        public int GenerateRandomSeed()
        {
            return new Random().Next(100, 9999);
        }
    }
}