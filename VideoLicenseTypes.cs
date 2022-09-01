namespace CodeHelper.API.YouTube
{
    internal struct VideoLicenseTypes
    {
        #region Properties
        /// <summary>
        /// Return all videos, regardless of which license they have, that match the query parameters.
        /// </summary>
        public const string Any = "any";
        /// <summary>
        /// Only return videos that have a Creative Commons license. Users can reuse videos with this license in other videos that they create. 
        /// </summary>
        public const string CreativeCommon = "creativeCommon";
        /// <summary>
        /// Only return videos that have the standard YouTube license.
        /// </summary>
        public const string YouTube = "youtube ";

        #endregion
    }
}
