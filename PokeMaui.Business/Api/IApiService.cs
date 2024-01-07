namespace PokeMaui.Business.Api
{
    public interface IApiService<TResponse>
    {
        void SetApiUrl(string apiUrl);
        public Task<TResponse> GetApiResponseAsync();      
    }
}