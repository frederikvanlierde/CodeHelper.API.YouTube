using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeHelper.Core.PlaceHolder;
namespace CodeHelper.API.YouTube
{
    public class SearchOptions
    {
        #region Properties
        [Placeholder("{REGIONCODE}")]   public string RegionCode { get; set; } = "";
        [Placeholder("{LANGUAGEID}")]    public string Language { get; set; } = "en_US";                    
        [Placeholder("{MAXRESULTS}")] public int Maxresults { get; set; } = 5;
        /// <summary>
        /// Indicates whether the API should filter video search results based on whether they have captions. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// Values: any, closedCaption or none 
        /// Use the VideoCaptionTypes struct for a full list
        /// </summary>
        [Placeholder("{VIDEOCAPTION}")] public string VideoCaption { get; set; } = "";
        /// <summary>
        /// Lets you restrict a search to only retrieve 2D or 3D videos. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// Values: 2d, 3d, any
        /// Use the VideDimensionTypes struct for a full list
        /// </summary>
        [Placeholder("{SAFESEARCH}")] public string SafeSearch { get; set; } = "";

        /// <summary>
        /// Indicates whether the search results should include restricted content as well as standard content.
        /// Values: none, moderate or strict 
        /// Use the SafeSearchTypes struct for a full list
        /// </summary>
        [Placeholder("{VIDEODIMENSION}")] public string VideoDimension { get; set; } = VideoCaptionTypes.Any;

        /// <summary>
        /// Indicates whether the search results should include restricted content as well as standard content.
        /// Values: none, moderate or strict 
        /// Use the SafeSearchTypes struct for a full list
        /// </summary>
        [Placeholder("{VIDEOLICENSE}")] public string VideoLicense { get; set; } = VideoLicenseTypes.Any;

        /// <summary>
        /// Indicates whether the search results should include restricted content as well as standard content.
        /// Values: none, moderate or strict 
        /// Use the SafeSearchTypes struct for a full list
        /// </summary>
        [Placeholder("{VIDEOTYPE}")] public string VideoType { get; set; } = VideoTypes.Any;

        #endregion
        #region Constructor
        public SearchOptions() { }
        #endregion
    }
}
