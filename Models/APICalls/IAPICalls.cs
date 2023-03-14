using MusicMafia.Models.HomePageModel;
using MusicMafia.Models.PlayNowSongModel;
using MusicMafia.Models.SearchPageModel;

namespace MusicMafia.Models.APICalls
{
    public interface IAPICalls
    {
        Task<HomePage> GetHomePage();
        Task<SearchPage> GetSearchItem(string query);
        Task<PlayNowSongPage> GetPlayNow(string playNowSongId);
    }
}
