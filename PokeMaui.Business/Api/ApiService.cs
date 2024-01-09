using Newtonsoft.Json;

namespace PokeMaui.Business.Api
{
    /// <summary>
    /// Generic ApiService
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public class ApiService : IApiService
    {
        private string _baseApiUrl;
        private readonly HttpClient _client;

        public ApiService(HttpClient client) => _client = client;

        public void SetBaseApiUrl(string baseApiUrl)
        {
            _baseApiUrl = baseApiUrl;
        }

        public async Task<TResponse> GetApiResponseAsync<TResponse>(string parameters = "")
        {
            try
            {
                var response = await _client.GetStringAsync(_baseApiUrl + parameters);
                var results = JsonConvert.DeserializeObject<TResponse>(response);
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }

        }
    }
}
