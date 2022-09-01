namespace CodeHelper.API.YouTube
{
    public struct EventTypes
    {
        #region Properties
        /// <summary>
        ///  Only include completed broadcasts.
        /// </summary>
        public const string Any = "";
        /// <summary>
        ///  Only include completed broadcasts.
        /// </summary>
        public const string Completed = "completed ";
        /// <summary>
        ///  Only retrieve shows
        /// </summary>
        public const string Live = "live ";

        /// <summary>
        ///  Only retrieve shows
        /// </summary>
        public const string Upcoming = "upcoming  ";

        #endregion
    }
}
