

using HaloStats.Models;

namespace HaloStats.Data
{
    public class HaloAPIClient
    {
        public HttpClient _httpClient;
        public string stats = "/service-record/global";
        //public string gamertag { get; set; }
        
        public HaloAPIClient(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<string> GetStats(string gamertag) 
        {
            var response = await _httpClient.GetAsync($"{gamertag}{stats}");
            response.EnsureSuccessStatusCode();
            //var ret = await response.Content.ReadAsStringAsync();
            //var arr = ret.Split('}');
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<data> GetSummary(string gamertag)
        {
            var response = await _httpClient.GetAsync($"{gamertag}{stats}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<data>();
        }

    }
}
