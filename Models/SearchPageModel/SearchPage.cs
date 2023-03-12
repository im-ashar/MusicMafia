namespace MusicMafia.Models.SearchPageModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class SearchPage
    {
        public string Status { get; set; }
        public object Message { get; set; }
        public Data Data { get; set; }
    }

    public class Albums
    {
        public List<Result> Results { get; set; }
        public int Position { get; set; }
    }

    public class Artists
    {
        public List<Result> Results { get; set; }
        public int Position { get; set; }
    }

    public class Data
    {
        public Songs Songs { get; set; }
        public Albums Albums { get; set; }
        public Artists Artists { get; set; }
        public Playlists Playlists { get; set; }
    }

    public class Image
    {
        public string Quality { get; set; }
        public string Link { get; set; }
    }

    public class Playlists
    {
        public List<Result> Results { get; set; }
        public int Position { get; set; }
    }

    public class Result
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Image> Image { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public string Album { get; set; }
        public string PrimaryArtists { get; set; }
        public string Singers { get; set; }
        public string Language { get; set; }
        public string Artist { get; set; }
        public string Year { get; set; }
        public string SongIds { get; set; }
    }



    public class Songs
    {
        public List<Result> Results { get; set; }
        public int Position { get; set; }
    }

}