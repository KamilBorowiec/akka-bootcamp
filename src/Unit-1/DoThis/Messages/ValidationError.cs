namespace WinTail.Messages
{
    /// <summary>
    /// User provided invalid input (currently, input w/ odd # chars)
    /// </summary>
    public class ValidationError : InputError
    {
        public ValidationError(string reason) : base(reason) { }
    }
}