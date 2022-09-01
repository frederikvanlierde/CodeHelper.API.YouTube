using System.Text.Json.Serialization;

namespace CodeHelper.API.YouTube.Common
{
    public class ImageInfo
    {
        #region Properties
        [JsonPropertyName("url")]       public string Url { get; set; } = "";
        [JsonPropertyName("width")]     public int Width { get; set; }
        [JsonPropertyName("height")]    public int Height { get; set; }
        #endregion
    }
}
