
using System.Text.Json.Serialization;

namespace CodeHelper.API.YouTube.Common
{
    public class Id
    {
        #region Properties
        [JsonPropertyName("kind")]      public string? Kind { get; set; }
        [JsonPropertyName("videoId")]   public string? VideoId { get; set; }
        #endregion
    }
}
