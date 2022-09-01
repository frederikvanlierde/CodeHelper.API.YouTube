using System.Text.Json.Serialization;

namespace CodeHelper.API.YouTube.Common
{
    public class PageInfo
    {
        #region Properties
        [JsonPropertyName("totalResults")]      public int TotalResults { get; set; }
        [JsonPropertyName("resultsPerPage")]    public int ResultsPerPage { get; set; }
        #endregion
    }
}
