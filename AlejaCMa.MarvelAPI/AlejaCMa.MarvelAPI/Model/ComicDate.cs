using Newtonsoft.Json;
using System;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The date of a Comic
    /// </summary>
    public class ComicDate
    {
        /// <summary>
        /// Gets or sets the description of the date (e.g.onsale date, FOC date)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the date
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }
    }
}
