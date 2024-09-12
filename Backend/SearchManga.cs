using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Backend
{
    public class SearchManga
    {
        private readonly HttpClient _httpClient;

        public SearchManga()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
        }

        public async Task<List<MangaSuggestion>> SendGetRequest(string parametr)
        {
            string url = $"https://2.readmanga.ru/search/suggestion?query={parametr}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                MangaResponse mangaResponse = JsonConvert.DeserializeObject<MangaResponse>(responseBody);
                return mangaResponse.Suggestions; 
            }
            else
            {
                throw new Exception($"Ошибка: {response.StatusCode}");
            }
        }
    }
       
       
}
