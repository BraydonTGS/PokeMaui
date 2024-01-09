namespace PokeMaui.Business.Api
{
    /// <summary>
    /// Interface used to define functionality that will be implemented by <see cref="ApiService{TResponse}"/>
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IApiService
    {
        public void SetBaseApiUrl(string baseApiUrl);
        public Task<TResponse> GetApiResponseAsync<TResponse>(string parameters = "");
    }
}