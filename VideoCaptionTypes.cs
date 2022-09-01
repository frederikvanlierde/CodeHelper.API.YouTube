using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHelper.API.YouTube
{
    public class VideoCaptionTypes
    {
        #region Properties
        /// <summary>
        ///  Do not filter results based on caption availability.
        /// </summary>
        public const string Any = "any";
        /// <summary>
        ///  Only include videos that have captions.
        /// </summary>
        public const string ClosedCaption = "closedCaption";
        /// <summary>
        /// Only include videos that do not have captions.
        /// </summary>
        public const string None = "none";
        #endregion
    }
}
