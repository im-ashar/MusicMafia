using Newtonsoft.Json;
using MusicMafia.Models.HomePageModel;
using MusicMafia.Models.SearchPageModel;
using MusicMafia.Models.PlayNowSongModel;
using MusicMafia.Models.PlayNowAlbumModel;
using MusicMafia.Models.PlayNowPlaylistModel;


namespace MusicMafia.Models.APICalls
{
    public class APICalls : IAPICalls
    {
        public async Task<HomePage> GetHomePage()
        {
            HttpClient client = new HttpClient();
            // Make the request and retrieve the response
            HttpResponseMessage response = await client.GetAsync("https://musicmafia.vercel.app/modules?language=hindi");

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
        public async Task<PlayNowSongPage> GetPlayNowSong(string playNowSongId)
        {
            HttpClient client = new HttpClient();
            // Make the request and retrieve the response
            HttpResponseMessage response = await client.GetAsync($"https://musicmafia.vercel.app/songs?id={playNowSongId}");

            // Read the response as a string
            var responseBody = await response.Content.ReadAsStringAsync();
            PlayNowSongPage obj = JsonConvert.DeserializeObject<PlayNowSongPage>(responseBody);
            return obj;
        }
        public async Task<PlayNowAlbumPage> GetPlayNowAlbum(string playNowAlbumId)
        {
            HttpClient client = new HttpClient();
            // Make the request and retrieve the response
            HttpResponseMessage response = await client.GetAsync($"https://musicmafia.vercel.app/albums?id={playNowAlbumId}");

            // Read the response as a string
            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("\"downloadUrl\":false", "\"downloadUrl\":[]");
            responseBody = responseBody.Replace("\"image\":false", "\"image\":[]");
            PlayNowAlbumPage obj = JsonConvert.DeserializeObject<PlayNowAlbumPage>(responseBody);
            return obj;
        }
        public async Task<PlayNowPlaylistPage> GetPlayNowPlaylist(string playNowPlaylistId)
        {
            HttpClient client = new HttpClient();
            // Make the request and retrieve the response
            HttpResponseMessage response = await client.GetAsync($"https://musicmafia.vercel.app/playlists?id={playNowPlaylistId}");

            // Read the response as a string
            var responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.Replace("\"downloadUrl\":false", "\"downloadUrl\":[]");
            responseBody = responseBody.Replace("\"image\":false", "\"image\":[]");
            PlayNowPlaylistPage obj = JsonConvert.DeserializeObject<PlayNowPlaylistPage>(responseBody);
            return obj;
        }
    }
}
