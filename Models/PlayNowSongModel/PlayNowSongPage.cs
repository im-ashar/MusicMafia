namespace MusicMafia.Models.PlayNowSongModel
{
    public class PlayNowSongPage
    {
        public string Status { get; set; }
        public object Message { get; set; }
        public List<Data> Data { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Album
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Data
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Album Album { get; set; }
        public string Year { get; set; }
        public string ReleaseDate { get; set; }
        public string Duration { get; set; }
        public string Label { get; set; }
        public string PrimaryArtists { get; set; }
        public string PrimaryArtistsId { get; set; }
        public string FeaturedArtists { get; set; }
        public string FeaturedArtistsId { get; set; }
        public int ExplicitContent { get; set; }
        public int PlayCount { get; set; }
        public string Language { get; set; }
        public string HasLyrics { get; set; }
        public string Url { get; set; }
        public string Copyright { get; set; }
        public List<Image> Image { get; set; }
        public List<DownloadUrl> DownloadUrl { get; set; }
    }

    public class DownloadUrl
    {
        public string Quality { get; set; }
        public string Link { get; set; }
    }

    public class Image
    {
        public string Quality { get; set; }
        public string Link { get; set; }
    }
}
