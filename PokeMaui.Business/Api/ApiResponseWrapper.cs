namespace PokeMaui.Business.Api
{
    /// <summary>
    /// API Response Wrapper that holds the Data from the API Request
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public class ApiResponseWrapper<TResponse>
    {
        private TResponse _data { get; set; }
        public TResponse GetDataFromResponse() => _data;
    }
}
