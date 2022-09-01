using System.Text.Json.Serialization;

namespace CodeHelper.API.YouTube.Common
{
    public class Thumbnails
    {
        #region Properties
        [JsonPropertyName("default")]   public ImageInfo Default { get; set; } = new();
        [JsonPropertyName("medium")]    public ImageInfo Medium { get; set; } = new();
        [JsonPropertyName("high")]      public ImageInfo High { get; set; } = new();
        #endregion
    }
}
