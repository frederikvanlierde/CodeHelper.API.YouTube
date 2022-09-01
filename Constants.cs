namespace CodeHelper.API.YouTube
{
    internal class Constants
    {
        #region Properties
        public const string APIURL_VIDEOCATEGORIES = "https://www.googleapis.com/youtube/v3/videoCategories?key={APIKEY}&part=snippet&hl={LANGUAGEID}&regionCode={REGIONCODE}&id={CATEGORYIDS}";
        public const string APIURL_SEARCH = "https://www.googleapis.com/youtube/v3/search?key={APIKEY}&part=snippet&channeltype={CHANNELTYPE}&eventtype={EVENTTYPE}&maxResults={MAXRESULTS}&order={SEARCHORDER}&q={SEARCHQUERY}&type={SEARCHTYPE}&videocaption={VIDEOCAPTION}&safesearch={SAFESEARCH}&videodimenion={VIDEODIMENSION}&videolicense={VIDEOLICENSE}&videotype={VIDEOTYPE}";

        #endregion
    }
}