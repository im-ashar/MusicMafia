namespace MusicMafia.Models.HomePageModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Album
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string PlayCount { get; set; }
        public string Language { get; set; }
        public string ExplicitContent { get; set; }
        public string SongCount { get; set; }
        public string Url { get; set; }
        public List<object> PrimaryArtists { get; set; }
        public List<object> FeaturedArtists { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Image> Image { get; set; }
        public List<object> Songs { get; set; }
        public string ReleaseDate { get; set; }
    }

    public class Album2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Artist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public object Image { get; set; }
        public string Type { get; set; }
        public string Role { get; set; }
    }

    public class Chart
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Type { get; set; }
        public List<Image> Image { get; set; }
        public string Url { get; set; }
        public string Firstname { get; set; }
        public string ExplicitContent { get; set; }
        public string Language { get; set; }
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
        public string Quality { get; set; }
        public string Link { get; set; }
    }

    public class Playlist
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Type { get; set; }
        public List<Image> Image { get; set; }
        public string Url { get; set; }
        public string SongCount { get; set; }
        public string Firstname { get; set; }
        public string FollowerCount { get; set; }
        public string LastUpdated { get; set; }
        public string ExplicitContent { get; set; }
    }

    public class PrimaryArtist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public object Image { get; set; }
        public string Type { get; set; }
        public string Role { get; set; }
    }

    public class HomePage
    {
        public string Status { get; set; }
        public object Message { get; set; }
        public Data Data { get; set; }
    }

    public class Song
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Album Album { get; set; }
        public string Year { get; set; }
        public string ReleaseDate { get; set; }
        public string Duration { get; set; }
        public string Label { get; set; }
        public List<PrimaryArtist> PrimaryArtists { get; set; }
        public List<object> FeaturedArtists { get; set; }
        public string ExplicitContent { get; set; }
        public string PlayCount { get; set; }
        public string Language { get; set; }
        public string Url { get; set; }
        public List<Image> Image { get; set; }
    }

    public class Trending
    {
        public List<Song> Songs { get; set; }
        public List<Album> Albums { get; set; }
    }

}