namespace WinTail.Messages
{
    // in Messages.cs
    /// <summary>
    /// Base class for signalling that user input was valid.
    /// </summary>
    public class InputSuccess
    {
        public InputSuccess(string reason)
        {
            Reason = reason;
        }

        public string Reason { get; private set; }
    }
}
