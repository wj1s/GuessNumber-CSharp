using System.Collections.Generic;
using GuessNumber.CustomConsole;
using Xunit;

namespace GuessNumber_Test.TestDouble
{
    public class ConsoleDouble : IConsole
    {
        public int Count = 0;

        public ConsoleDouble(List<string> inputs)
        {
            Inputs = inputs;
            Message = new List<string>();
            CalList = new List<string>();
        }

        public List<string> Inputs { get; private set; }
        public List<string> Message { get; private set; }
        public List<string> CalList { get; private set; }


        public string ReadLine()
        {
            CalList.Add("Read");
            string first = Inputs[Count];
            Count++;
            return first;
        }

        public void WriteLine(string message)
        {
            CalList.Add("Write");
            Message.Add(message);
        }

        public void Verify()
        {
            Assert.Equal(6, CalList.Count);
            Assert.Equal("Write", CalList[0]);
            Assert.Equal("Read", CalList[1]);
            Assert.Equal("Write", CalList[2]);
            Assert.Equal("Write", CalList[3]);
            Assert.Equal("Read", CalList[4]);
            Assert.Equal("Write", CalList[5]);
        }
    }
}