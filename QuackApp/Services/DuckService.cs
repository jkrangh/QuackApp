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

        public async Task<Duck> GetDuckJpgAsync()
        {
            var response = await httpClient.GetAsync(url + "?type=jpg");

            if (response.IsSuccessStatusCode)
            { 
                duck = await response.Content.ReadFromJsonAsync<Duck>();
            }
            return duck;
        }

        public async Task<Duck> GetDuckGifAsync()
        {
            var response = await httpClient.GetAsync(url + "?type=gif");

            if (response.IsSuccessStatusCode)
            {
                duck = await response.Content.ReadFromJsonAsync<Duck>();
            }
            return duck;
        }
    }
}
