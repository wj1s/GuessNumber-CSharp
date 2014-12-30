using GuessNumber;
using GuessNumber.RandomSeed;
using GuessNumber_Test.TestDouble;
using Xunit;

namespace GuessNumber_Test
{
    public class NumberGenerateFacts
    {
        [Fact]
        public void should_return_1234_when_random_generate_1234()
        {
            IRandomSeed randomSeed = new RandomSeedGenerateStub(new[]{1234});
            var generate = new NumberGenerate(randomSeed).Generate();
            Assert.Equal("1234",generate);
        }

        [Fact]
        public void should_return_0123_when_random_generate_123()
        {
            IRandomSeed randomSeed = new RandomSeedGenerateStub(new[]{123});
            var generate = new NumberGenerate(randomSeed).Generate();
            Assert.Equal("0123", generate);
        }

        [Fact]
        public void should_return_1234_when_random_generate_1123_and_1234()
        {
            IRandomSeed randomSeed = new RandomSeedGenerateStub(new[]{1123,1234});
            var generate = new NumberGenerate(randomSeed).Generate();
            Assert.Equal("1234", generate);
        }

        [Fact]
        public void should_return_1234_when_random_generate_102_and_1234()
        {
            IRandomSeed randomSeed = new RandomSeedGenerateStub(new[] { 102, 1234 });
            var generate = new NumberGenerate(randomSeed).Generate();
            Assert.Equal("1234", generate);
        }

        [Fact]
        public void should_return_1203_when_random_generate_1203()
        {
            IRandomSeed randomSeed = new RandomSeedGenerateStub(new[] { 1203});
            var generate = new NumberGenerate(randomSeed).Generate();
            Assert.Equal("1203", generate);
        }
    }
}