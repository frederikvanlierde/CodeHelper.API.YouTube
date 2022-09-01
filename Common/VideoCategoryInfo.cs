using System.Text.Json.Serialization;

namespace CodeHelper.API.YouTube.Common
{
    public class VideoCategoryInfo
    {
        #region Properties
        [JsonPropertyName("kind")]      public string? Kind { get; set; }
        [JsonPropertyName("etag")]      public string? Etag { get; set; }
        [JsonPropertyName("id")]        public string? Id { get; set; }
        [JsonPropertyName("snippet")]   public Snippet? Categories { get; set; }
        #endregion
    }
}
