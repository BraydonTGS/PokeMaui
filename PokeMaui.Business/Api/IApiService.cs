namespace PokeMaui.Business.Api
{
    /// <summary>
    /// Interface used to define functionality that will be implemented by <see cref="ApiService{TResponse}"/>
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IApiService<TResponse>
    {
        void SetApiUrl(string apiUrl, string parameters);
        public Task<TResponse> GetApiResponseAsync();      
    }
}