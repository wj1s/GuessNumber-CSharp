using System.Collections.Generic;
using GuessNumber;
using GuessNumber_Test.TestDouble;
using Xunit;

namespace GuessNumber_Test
{
    public class ProgramFacts
    {
        [Fact]
        public void should_return_numbers()
        {
            var consoleSpy = new ConsoleDouble(new List<string> { "4231", "1234" });
            Program.Console = consoleSpy;
            Program.RandomSeedGenerate = new RandomSeedGenerateStub(new[] { 1234 });

            Program.Main();

            Assert.Equal("please input a number:", consoleSpy.Message[0]);
            Assert.Equal("2A2B", consoleSpy.Message[1]);
            Assert.Equal("please input a number:", consoleSpy.Message[2]);
            Assert.Equal("4A0B", consoleSpy.Message[3]);
            consoleSpy.Verify();
        }
    }
}