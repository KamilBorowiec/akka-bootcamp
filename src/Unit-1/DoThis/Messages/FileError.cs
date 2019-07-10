namespace WinTail.Messages
{
    /// <summary>
    /// Signal that the OS had an error accessing the file.
    /// </summary>
    public class FileError
    {
        public FileError(string fileName, string reason)
        {
            FileName = fileName;
            Reason = reason;
        }

        public string FileName { get; private set; }

        public string Reason { get; private set; }
    }
}