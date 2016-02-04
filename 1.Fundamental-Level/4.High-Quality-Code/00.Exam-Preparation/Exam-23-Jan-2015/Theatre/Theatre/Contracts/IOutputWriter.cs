namespace Theatre.Contracts
{
    public interface IOutputWriter
    {
        void Write(string text);

        void WriteLine(string text);
    }
}