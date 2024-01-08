using Newtonsoft.Json;

namespace PokeMaui.Business.Api
{
    /// <summary>
    /// Generic ApiService
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public class ApiService<TResponse> : IApiService<TResponse>
    {
        private string _apiUrl;
        private readonly HttpClient _client;

        public ApiService(HttpClient client) => _client = client;

        public void SetApiUrl(string apiUrl, string parameters = "") => _apiUrl = apiUrl + parameters;

        public void ResetApiUrl() => _apiUrl = string.Empty;

        public async Task<TResponse> GetApiResponseAsync()
        {
            var response = await _client.GetStringAsync(_apiUrl + typeof(TResponse));

            var results = JsonConvert.DeserializeObject<TResponse>(response);

            return results;
        }
    }
}
