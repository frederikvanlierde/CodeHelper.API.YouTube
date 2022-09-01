using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHelper.API.YouTube
{
    internal struct VideDimensionTypes
    {
        #region Properties
        /// <summary>
        /// Restrict search results to exclude 3D videos.
        /// </summary>
        public const string Only2d = "2d";
        /// <summary>
        /// Restrict search results to only include 3D videos.
        /// </summary>
        public const string Only3d = "3d";
        /// <summary>
        /// Include both 3D and non-3D videos in returned results. This is the default value.
        /// </summary>
        public const string Any = "any";
        #endregion
    }
}
