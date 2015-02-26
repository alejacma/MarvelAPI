using Newtonsoft.Json;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The summary view of a Comic
    /// </summary>
    public class ComicSummary
    {
        /// <summary>
        /// Gets or sets the canonical URL identifier for this resource
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// Gets or sets the name of the comic
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
