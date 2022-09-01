namespace CodeHelper.API.YouTube
{
    public struct SafeSearchTypes
    {
        #region Properties
        /// <summary>
        ///   YouTube will filter some content from search results and, at the least, will filter content that is restricted in your locale. Based on their content, search results could be removed from search results or demoted in search results. This is the default parameter value.
        /// </summary>
        public const string None = "none";
        /// <summary>
        /// YouTube will not filter the search result set.
        /// </summary>
        public const string Moderate = "moderate  ";
        /// <summary>
        /// YouTube will try to exclude all restricted content from the search result set. Based on their content, search results could be removed from search results or demoted in search results.
        /// </summary>
        public const string Strict = "strict ";

        #endregion
    }
}
