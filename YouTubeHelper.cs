using System.Text.Json;
using CodeHelper.Core.PlaceHolder;
using CodeHelper.API.YouTube.Common;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CodeHelper.API.YouTube
{
    public class YouTubeHelper
    {
        #region Properties
        private readonly HttpClient _httpClient = new();
        public string AccessToken { get; set; } = "";
        [Placeholder("{APIKEY}")]       public string ApiKey { get; set; } = "";

        [Placeholder("{SEARCHQUERY}")]      public string SearchQuery { get; set; } = "";
        [Placeholder("{SEARCHTYPE}")]       public string SearchType { get; set; } = ""; 
        [Placeholder("{SEARCHORDER}")]      public string SearchOrder{ get; set; } = "";

        [Placeholder("{CATEGORYIDS}")] public string CategoriesIDS { get; set; } = "";
        [Placeholder("{CHANNELTYPE}")] public string ChannelType { get; set; } = ChannelTypes.Any;
        [Placeholder("{EVENTTYPE}")] public string EventType { get; set; } = ChannelTypes.Any;
        public SearchOptions? SearchOptions { get; set; } = new();
        
        #endregion

        #region Constructors
        public YouTubeHelper() { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns a collection of search results, including videos, channels and playlists that match the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        public async Task<SearchResultResponse> Search(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null)
        {
            this.SearchQuery = HttpUtility.UrlEncode(searchQuery);
            this.SearchType = SearchTypes.Any;
            this.SearchOrder = searchOrder;
            return await Search();
        }
        /// <summary>
        /// Returns a collection of Videos that match the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchVideos(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null)
        {
            this.SearchQuery = HttpUtility.UrlEncode(searchQuery);
            this.SearchType = SearchTypes.Video;
            this.SearchOrder = searchOrder;
            return await Search();
        }
        /// <summary>
        /// Returns a collection of 3D Videos that match the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> Search3DVideos(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null)
        {
            this.SearchQuery = HttpUtility.UrlEncode(searchQuery);
            this.SearchType = SearchTypes.Video;
            this.SearchOrder = searchOrder;
            if (this.SearchOptions == null)
                this.SearchOptions = new();
            this.SearchOptions.VideoDimension = VideDimensionTypes.Only3d;
            return await Search();
        }

        /// <summary>
        /// Returns a collection of Videos hat have a Creative Commons license. Users can reuse videos with this license in other videos that they create.
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchCreativeCommonVideos(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null)
        {
            this.SearchQuery = HttpUtility.UrlEncode(searchQuery);
            this.SearchType = SearchTypes.Video;
            this.SearchOrder = searchOrder;
            if (this.SearchOptions == null)
                this.SearchOptions = new();
            this.SearchOptions.VideoLicense = VideoLicenseTypes.CreativeCommon;
            return await Search();
        }

        /// <summary>
        /// Returns a collection of Movies
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchMovies(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null)
        {
            this.SearchQuery = HttpUtility.UrlEncode(searchQuery);
            this.SearchType = SearchTypes.Video;
            this.SearchOrder = searchOrder;
            if (this.SearchOptions == null)
                this.SearchOptions = new();
            this.SearchOptions.VideoType = VideoTypes.Movie;
            return await Search();
        }


        /// <summary>
        /// Returns a collection of Channels that match the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchChannels(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null)
        {
            this.SearchQuery = HttpUtility.UrlEncode(searchQuery);
            this.SearchType = SearchTypes.Channel;
            this.SearchOrder = searchOrder;
            return await Search();
        }
        /// <summary>
        /// Returns a collection of Playlists that match the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchPlayLists(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null)
        {
            this.SearchQuery = HttpUtility.UrlEncode(searchQuery);
            this.SearchType = SearchTypes.Playlist;
            this.SearchOrder = searchOrder;
            return await Search();
        }

        /// <summary>
        /// Returns a collection of broadcast events that matches the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchBroadcastEvents(string searchQuery, string eventType = EventTypes.Completed, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOption = null)
        {
            this.SearchQuery = searchQuery;
            this.EventType = eventType;
            this.SearchOrder = searchOrder;
            this.SearchOptions = searchOption;
            return await Search();            
        }
        /// Returns a collection of broadcast events that are currentl are active/live and matches the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchLiveEvents(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOption = null)
        {
            this.SearchQuery = searchQuery;
            this.EventType = EventTypes.Live;
            this.SearchOrder = searchOrder;
            this.SearchOptions = searchOption;
            return await Search();
        }
        /// Returns a collection of upcoming broadcast events that matches the query parameters 
        /// Quota impact: A call to this method has a quota cost of 100 units.
        /// </summary>
        /// <param name="searchQuery">Mandatory: search </param>
        /// <param name="searchOrder">optional string: specifies the method that will be used to order resources in the API response. The default value is relevance. (use struct SearchOrderTypes for full list)</param>
        /// <param name="searchOptions">Optional: a set of extra searchoptions like language, max reuslts etc...</param>
        public async Task<SearchResultResponse> SearchUpcomingEvents(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOption = null)
        {
            this.SearchQuery = searchQuery;
            this.EventType = EventTypes.Upcoming;
            this.SearchOrder = searchOrder;
            this.SearchOptions = searchOption;
            return await Search();
        }
        /// <summary>
        /// Returns a list of categories that can be associated with YouTube videos.
        /// regionCode OR categoriesIDS must be given to have a successfull result
        /// Quota impact: A call to this method has a quota cost of 1 unit.
        /// </summary>
        /// <param name="regionCode">Optional :  Specifies the country for which categories are being retrieved.</param>
        /// <param name="language">Optional: Specifies the language that should be used for text values in the API response. The default value is en_US.</param>
        /// <param name="categoriesIDS">Optional:  A comma-separated list of video category IDs for the resources that you are retrieving.</param>
        public async Task<List<VideoCategoryInfo>> GetVideoCategoriesList(string regionCode="", string categoriesIDS = "", SearchOptions? searchOption = null)
        {
            this.SearchOptions = searchOption;
            this.CategoriesIDS = categoriesIDS;
            return (JsonSerializer.Deserialize<VideoCategoryResult>(await GetJson(Constants.APIURL_VIDEOCATEGORIES, false)).VideoCategories) ?? new();
            
        }
        #endregion

        #region Private methods
        protected async Task<string> GetJson(string apiURL, bool oauth2)
        {
            if(oauth2)
                SetAuthorizationHeader();
            apiURL = apiURL.Replace(this.SearchOptions, false);
            apiURL = apiURL.Replace(this, true);
            var _task = await _httpClient.GetAsync(apiURL);
            var _r = await _task.Content.ReadAsStringAsync();
            return _r;
        }

        private void SetAuthorizationHeader()
        {
            
            if (_httpClient.DefaultRequestHeaders.Contains("Authorization"))
                _httpClient.DefaultRequestHeaders.Remove("Authorization");
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + this.AccessToken);
        }

        private async Task<SearchResultResponse> Search()
        {
            return (JsonSerializer.Deserialize<SearchResultResponse>(await GetJson(Constants.APIURL_SEARCH,false))) ?? new();
        }
        #endregion
    }
}
