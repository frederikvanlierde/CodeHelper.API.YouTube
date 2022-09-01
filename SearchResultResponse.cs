using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CodeHelper.API.YouTube.Common;
namespace CodeHelper.API.YouTube
{
    public class SearchResultResponse
    {
        #region Propertis
        [JsonPropertyName("kind")]          public string? Kind { get; set; }
        [JsonPropertyName("etag")]          public string? Etag { get; set; }
        [JsonPropertyName("nextPageToken")] public string? NextPageToken { get; set; }
        [JsonPropertyName("regionCode")]    public string? RegionCode { get; set; }
        [JsonPropertyName("pageInfo")]      public PageInfo? PageInfo { get; set; }
        [JsonPropertyName("items")]         public List<SearchResult> Items { get; set; } = new();
        #endregion
        #region Constructors
        public SearchResultResponse() { }
        #endregion
    }
}
