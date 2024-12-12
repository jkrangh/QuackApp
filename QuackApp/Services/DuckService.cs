using QuackApp.Models;
using System.Net.Http.Json;

namespace QuackApp.Services
{
    public class DuckService
    {
        HttpClient httpClient;
        Duck duck = new Duck();
        string url = "https://random-d.uk/api/v2/random";

        public DuckService()
        {
            httpClient = new HttpClient();
        }

        public async Task<Duck> GetDuckAsync()
        {
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            { 
                duck = await response.Content.ReadFromJsonAsync<Duck>();
            }
            return duck;
        }
    }
}
