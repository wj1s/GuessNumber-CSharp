using GuessNumber;
using Xunit;

namespace GuessNumber_Test
{
    public class NumberCompareFacts
    {
        [Fact]
        public void should_0A0B_when_compare_1234_5678()
        {
            Assert.Equal("0A0B",NumberCompare.Compare("1234","5678"));
        }

        [Fact]
        public void should_1A0B_when_compare_1234_1678()
        {
            Assert.Equal("1A0B", NumberCompare.Compare("1234", "1678"));
        }

        [Fact]
        public void should_2A0B_when_compare_1234_1278()
        {
            Assert.Equal("2A0B", NumberCompare.Compare("1234", "1278"));
        }

        [Fact]
        public void should_3A0B_when_compare_1234_1238()
        {
            Assert.Equal("3A0B", NumberCompare.Compare("1234", "1238"));
        }

        [Fact]
        public void should_4A0B_when_compare_1234_1234()
        {
            Assert.Equal("4A0B", NumberCompare.Compare("1234", "1234"));
        }

        [Fact]
        public void should_2A0B_when_compare_9284_1234()
        {
            Assert.Equal("2A0B", NumberCompare.Compare("9284", "1234"));
        }

        [Fact]
        public void should_0A1B_when_compare_1234_5178()
        {
            Assert.Equal("0A1B", NumberCompare.Compare("1234", "5178"));
        }

        [Fact]
        public void should_1A3B_when_compare_1234_3124()
        {
            Assert.Equal("1A3B", NumberCompare.Compare("1234", "3124"));
        }
    }
}
