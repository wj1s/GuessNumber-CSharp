namespace GuessNumber.CustomConsole
{
    public interface IConsole
    {
        void WriteLine(string message);
        string ReadLine();
    }
}