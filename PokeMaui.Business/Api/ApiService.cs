using Newtonsoft.Json;
using PokeMaui.Global.Exceptions;

namespace PokeMaui.Business.Api
{
    /// <summary>
    /// ApiService - Implements IApiService
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
                if(results is null) return default;
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }

        }
    }
}
