namespace Blobs.IO.Interfaces
{
    public interface IInputReader
    {
        /// <summary>
        /// Reads an line from the input stream.
        /// </summary>
        /// <returns>String read from an line.</returns>
        string ReadLine();
    }
}
