namespace MusicMafia.Models.SearchPageModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class SearchPage
    {
        public object Status { get; set; }
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
        public object Quality { get; set; }
        public object Link { get; set; }
    }

    public class Playlists
    {
        public List<Result> Results { get; set; }
        public int Position { get; set; }
    }

    public class Result
    {
        public object Id { get; set; }
        public object Title { get; set; }
        public List<Image> Image { get; set; }
        public object Url { get; set; }
        public object Type { get; set; }
        public object Description { get; set; }
        public int Position { get; set; }
        public object Album { get; set; }
        public object PrimaryArtists { get; set; }
        public object Singers { get; set; }
        public object Language { get; set; }
        public object Artist { get; set; }
        public object Year { get; set; }
        public object SongIds { get; set; }
    }



    public class Songs
    {
        public List<Result> Results { get; set; }
        public int Position { get; set; }
    }

}