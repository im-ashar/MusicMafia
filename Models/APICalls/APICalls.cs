using Newtonsoft.Json;
using MusicMafia.Models.HomePageModel;
using MusicMafia.Models.SearchPageModel;
using MusicMafia.Models.PlayNowSongModel;

namespace MusicMafia.Models.APICalls
{
    public class APICalls:IAPICalls
    {
        public async Task<HomePage> GetHomePage()
        {
            HttpClient client = new HttpClient();
            // Make the request and retrieve the response
            HttpResponseMessage response = await client.GetAsync("https://musicmafia.vercel.app/modules?language=hindi,urdu");

            // Read the response as a string
            var responseBody = await response.Content.ReadAsStringAsync();
            HomePage obj = JsonConvert.DeserializeObject<HomePage>(responseBody);
            return obj;
        }
        public async Task<SearchPage> GetSearchItem(string query)
        {
            HttpClient client = new HttpClient();
            // Make the request and retrieve the response
            HttpResponseMessage response = await client.GetAsync($"https://musicmafia.vercel.app/search/all?query={query}");

            // Read the response as a string
            var responseBody = await response.Content.ReadAsStringAsync();
            SearchPage obj = JsonConvert.DeserializeObject<SearchPage>(responseBody);
            return obj;
        }
        public async Task<PlayNowSongPage> GetPlayNow(string playNowSongId)
        {
            HttpClient client = new HttpClient();
            // Make the request and retrieve the response
            HttpResponseMessage response = await client.GetAsync($"https://musicmafia.vercel.app/songs?id={playNowSongId}");

            // Read the response as a string
            var responseBody = await response.Content.ReadAsStringAsync();
            PlayNowSongPage obj = JsonConvert.DeserializeObject<PlayNowSongPage>(responseBody);
            return obj;
        }
    }
}
