namespace CodeHelper.API.YouTube
{
    public struct SearchOrderTpes
    {
        #region Properties
        /// <summary>
        ///  Resources are sorted in reverse chronological order based on the date they were created.
        /// </summary>
        public const string Date = "date";
        /// <summary>
        ///  Resources are sorted from highest to lowest rating.
        /// </summary>
        public const string Rating = "rating";
        /// <summary>
        ///  Resources are sorted based on their relevance to the search query. This is the default value for this parameter.
        /// </summary>
        public const string Relevance = "relevance";

        /// <summary>
        /// Resources are sorted alphabetically by title.
        /// </summary>
        public const string Title = "title";

        /// <summary>
        /// Channels are sorted in descending order of their number of uploaded videos.
        /// </summary>
        public const string VideoCount = "videoCount";
        /// <summary>
        /// Resources are sorted from highest to lowest number of views. For live broadcasts, videos are sorted by number of concurrent viewers while the broadcasts are ongoing.
        /// </summary>
        public const string ViewCount = "viewCount";

        #endregion
    }
}
