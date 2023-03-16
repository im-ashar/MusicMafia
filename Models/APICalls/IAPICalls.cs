using MusicMafia.Models.HomePageModel;
using MusicMafia.Models.PlayNowSongModel;
using MusicMafia.Models.SearchPageModel;
using MusicMafia.Models.PlayNowAlbumModel;
using MusicMafia.Models.PlayNowPlaylistModel;

namespace MusicMafia.Models.APICalls
{
    public interface IAPICalls
    {
        Task<HomePage> GetHomePage();
        Task<SearchPage> GetSearchItem(string query);
        Task<PlayNowSongPage> GetPlayNowSong(string playNowSongId);
        Task<PlayNowAlbumPage> GetPlayNowAlbum(string playNowAlbumId);
        Task<PlayNowPlaylistPage> GetPlayNowPlaylist(string playNowPlaylistId);
    }
}
