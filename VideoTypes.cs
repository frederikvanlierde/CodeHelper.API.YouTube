namespace CodeHelper.API.YouTube
{
    internal struct VideoTypes
    {
        #region Properties
        /// <summary>
        ///Return all videos.
        /// </summary>
        public const string Any = "any";
        /// <summary>
        /// Only retrieve episodes of shows.
        /// </summary>
        public const string Episode = "episode";
        /// <summary>
        /// Only retrieve movies.
        /// </summary>
        public const string Movie = "movie  ";

        #endregion
    }
}
