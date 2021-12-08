

using HaloStats.Models;

namespace HaloStats.Data
{
    public class HaloAPIClient
    {
        public HttpClient _httpClient;
        public string con = "/service-record/global";
        public string gamertag { get; set; }
        public HaloAPIClient(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<string> GetStats() 
        {
            var response = await _httpClient.GetAsync($"{gamertag}{con}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<Summary> GetSummary()
        {
            var response = await _httpClient.GetAsync($"{gamertag}{con}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<Summary>();
        }

    }
}
