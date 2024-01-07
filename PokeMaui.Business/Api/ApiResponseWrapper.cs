namespace PokeMaui.Business.Api
{
    public class ApiResponseWrapper<TResponse>
    {
        private TResponse _data { get; set; }
        public TResponse GetDataFromResponse() => _data;
    }
}
