﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace MusicMafia.Models.PlayNowPlaylistModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class PlayNowPlaylistPage
    {
        public object Status { get; set; }
        public object Message { get; set; }
        public Data Data { get; set; }
    }
    public class Album
    {
        public object Id { get; set; }
        public object Name { get; set; }
        public object Url { get; set; }
    }

    public class Data
    {
        public object Id { get; set; }
        public object UserId { get; set; }
        public object Name { get; set; }
        public object FollowerCount { get; set; }
        public object SongCount { get; set; }
        public object FanCount { get; set; }
        public object Username { get; set; }
        public object Firstname { get; set; }
        public object Lastname { get; set; }
        public object Shares { get; set; }
        public List<Image> Image { get; set; }
        public object Url { get; set; }
        public List<Song> Songs { get; set; }
    }

    public class DownloadUrl
    {
        public object Quality { get; set; }
        public object Link { get; set; }
    }

    public class Image
    {
        public object Quality { get; set; }
        public object Link { get; set; }
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
        public object PrimaryArtists { get; set; }
        public object PrimaryArtistsId { get; set; }
        public object FeaturedArtists { get; set; }
        public object FeaturedArtistsId { get; set; }
        public int ExplicitContent { get; set; }
        public object PlayCount { get; set; }
        public object Language { get; set; }
        public object HasLyrics { get; set; }
        public object Url { get; set; }
        public object Copyright { get; set; }
        public List<Image> Image { get; set; }
        public List<DownloadUrl> DownloadUrl { get; set; }
    }
    


}


