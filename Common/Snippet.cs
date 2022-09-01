using System.Text.Json.Serialization;
using System;

namespace CodeHelper.API.YouTube.Common
{
    public class Snippet
    {
        #region Properties
        [JsonPropertyName("title")]         public string Title { get; set; } = "";
        [JsonPropertyName("assignable")]    public bool Assignable { get; set; }
        [JsonPropertyName("publishedAt")]   public DateTime PublishedAt { get; set; }
        [JsonPropertyName("publishTime")]   public DateTime PublishTime { get; set; }
        [JsonPropertyName("channelId")]     public string ChannelId { get; set; } = "";
        [JsonPropertyName("channelTitle")] public string ChannelTitle { get; set; } = "";
        [JsonPropertyName("description")]   public string Description { get; set; } = "";
        [JsonPropertyName("thumbnails")]    public Thumbnails Thumbnails { get; set; } = new();
        [JsonPropertyName("liveBroadcastContent")] public string LiveBroadcastContent { get; set; } = "";        
        #endregion
    }
}
