using Newtonsoft.Json;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The summary view of a Story
    /// </summary>
    public class StorySummary
    {
        /// <summary>
        /// Gets or sets the canonical URL identifier for this resource
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// Gets or sets the name of the story
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the story type e.g.interior story, cover, text story
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
