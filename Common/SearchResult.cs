using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodeHelper.API.YouTube.Common
{
    public class SearchResult
    {
        #region Properties
        [JsonPropertyName("kind")]      public string Kind { get; set; } = "";
        [JsonPropertyName("etag")]      public string Etag { get; set; } = "";
        [JsonPropertyName("id")]        public Id Id { get; set; } = new();
        [JsonPropertyName("snippet")]   public Snippet Snippet { get; set; } = new();
        #endregion
    }
}
