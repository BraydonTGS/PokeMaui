namespace PokeMaui.Global.Exceptions
{
    /// <summary>
    /// Custom exception class for API-related errors
    /// </summary>
    public class ApiException : Exception
    {
        public ApiException(string message) : base(message) { }

        public ApiException(string message, Exception innerException) : base(message, innerException) { }

    }
}
