using System.Collections.Generic;
using System.Text.Json.Serialization;
using CodeHelper.API.YouTube.Common;

namespace CodeHelper.API.YouTube
{
    public class VideoCategoryResult
    {
        #region Properties
        [JsonPropertyName("kind")]      public string? Kind { get; set; }
        [JsonPropertyName("etag")]      public string? Etag { get; set; }
        [JsonPropertyName("items")]     public List<VideoCategoryInfo> VideoCategories { get; set; } = new();
        #endregion
    }
}
