using Microsoft.AspNetCore.Mvc;
using MusicMafia.Models;
using MusicMafia.Models.APICalls;
using System.Diagnostics;

namespace MusicMafia.Controllers
{
    public class HomeController : Controller
    {
        IAPICalls _apicalls;
        public HomeController(IAPICalls apicalls)
        {
            _apicalls = apicalls;
        }

        public IActionResult HomePage()
        {
            var trending=_apicalls.GetHomePage();
            return View(trending);
        }

        public IActionResult SearchPage(string query)
        {
            var searchList = _apicalls.GetSearchItem(query);
            return View(searchList);
        }
        public IActionResult PlayNowSong(string playNowSongId)
        {
            var playNowSongResult = _apicalls.GetPlayNowSong(playNowSongId);
            return View(playNowSongResult);
        }
        public IActionResult PlayNowAlbum(string playNowAlbumId)
        {
            var playNowAlbumResult = _apicalls.GetPlayNowAlbum(playNowAlbumId);
            return View(playNowAlbumResult);
        }
        public IActionResult PlayNowPlaylist(string playNowPlaylistId)
        {
            var playNowPlaylistResult = _apicalls.GetPlayNowPlaylist(playNowPlaylistId);
            return View(playNowPlaylistResult);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}