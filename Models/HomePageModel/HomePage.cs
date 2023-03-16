namespace MusicMafia.Models.HomePageModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Album
    {
        public object Id { get; set; }
        public object Name { get; set; }
        public object Year { get; set; }
        public object Type { get; set; }
        public object PlayCount { get; set; }
        public object Language { get; set; }
        public object ExplicitContent { get; set; }
        public object SongCount { get; set; }
        public object Url { get; set; }
        public List<object> PrimaryArtists { get; set; }
        public List<object> FeaturedArtists { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Image> Image { get; set; }
        public List<object> Songs { get; set; }
        public object ReleaseDate { get; set; }
    }

    public class Album2
    {
        public object Id { get; set; }
        public object Name { get; set; }
        public object Url { get; set; }
    }

    public class Artist
    {
        public object Id { get; set; }
        public object Name { get; set; }
        public object Url { get; set; }
        public object Image { get; set; }
        public object Type { get; set; }
        public object Role { get; set; }
    }

    public class Chart
    {
        public object Id { get; set; }
        public object Title { get; set; }
        public object Subtitle { get; set; }
        public object Type { get; set; }
        public List<Image> Image { get; set; }
        public object Url { get; set; }
        public object Firstname { get; set; }
        public object ExplicitContent { get; set; }
        public object Language { get; set; }
    }

    public class Data
    {
        public List<Album> Albums { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Chart> Charts { get; set; }
        public Trending Trending { get; set; }
    }

    public class Image
    {
        public object Quality { get; set; }
        public object Link { get; set; }
    }

    public class Playlist
    {
        public object Id { get; set; }
        public object UserId { get; set; }
        public object Title { get; set; }
        public object Subtitle { get; set; }
        public object Type { get; set; }
        public List<Image> Image { get; set; }
        public object Url { get; set; }
        public object SongCount { get; set; }
        public object Firstname { get; set; }
        public object FollowerCount { get; set; }
        public object LastUpdated { get; set; }
        public object ExplicitContent { get; set; }
    }

    public class PrimaryArtist
    {
        public object Id { get; set; }
        public object Name { get; set; }
        public object Url { get; set; }
        public object Image { get; set; }
        public object Type { get; set; }
        public object Role { get; set; }
    }

    public class HomePage
    {
        public object Status { get; set; }
        public object Message { get; set; }
        public Data Data { get; set; }
    }

    public class Song
    {
        public object Id { get; set; }
        public object Name { get; set; }
        public object Type { get; set; }
        public Album Album { get; set; }
        public object Year { get; set; }
        public object ReleaseDate { get; set; }
        public object Duration { get; set; }
        public object Label { get; set; }
        public List<PrimaryArtist> PrimaryArtists { get; set; }
        public List<object> FeaturedArtists { get; set; }
        public object ExplicitContent { get; set; }
        public object PlayCount { get; set; }
        public object Language { get; set; }
        public object Url { get; set; }
        public List<Image> Image { get; set; }
    }

    public class Trending
    {
        public List<Song> Songs { get; set; }
        public List<Album> Albums { get; set; }
    }

}