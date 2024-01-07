using Newtonsoft.Json;

namespace PokeMaui.Business.Api
{
    public class ApiService<TResponse> : IApiService<TResponse>
    {
        private string _apiUrl;
        private readonly HttpClient _client;

        public ApiService(HttpClient client) => _client = client;

        public void SetApiUrl(string apiUrl) => _apiUrl = apiUrl;

        public async Task<TResponse> GetApiResponseAsync()
        {
            var response = await _client.GetStringAsync(_apiUrl + typeof(TResponse));

            var results = JsonConvert.DeserializeObject<TResponse>(response);

            return results;
        }
    }
}
