using MusicMafia.Models.HomePageModel;
using MusicMafia.Models.SearchPageModel;

namespace MusicMafia.Models.APICalls
{
    public interface IAPICalls
    {
        Task<HomePage> GetHomePage();
        Task<SearchPage> GetSearchItem(string query);
    }
}
