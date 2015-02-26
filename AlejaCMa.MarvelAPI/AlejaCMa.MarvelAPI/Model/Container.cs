using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Displays pagination information and an array of the results returned by this call. 
    /// </summary>
    /// <typeparam name="T">The type of the results returned by the call</typeparam>
    public class Container<T>
    {
        /// <summary>
        /// Gets or sets the requested offset(skipped results) of the call
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the requested result limit
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the total number of results available 
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets the total number of results returned by this call
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of entities returned by the call
        /// </summary>
        [JsonProperty("results")]
        public List<T> Results { get; set; }
    }
}
