namespace Blobs.IO.Interfaces
{
    public interface IOutputWriter
    {
        /// <summary>
        /// Writes the specificed string to the output stream.
        /// </summary>
        /// <param name="message">Given string.</param>
        void Print(string message);
    }
}
