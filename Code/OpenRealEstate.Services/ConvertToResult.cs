﻿using System.Collections.Generic;

namespace OpenRealEstate.Services
{
    public class ConvertToResult
    {
        /// <summary>
        /// Successfully parsed listings.
        /// </summary>
        public IList<ListingResult> Listings { get; set; }

        /// <summary>
        /// Xml elements (children to the root node) that are not handled.
        /// </summary>
        public IList<string> UnhandledData { get; set; }

        /// <summary>
        /// Xml elements that failed to be parsed / contained bad data / etc.
        /// </summary>
        public IList<ParsedError> Errors { get; set; }
    }
}