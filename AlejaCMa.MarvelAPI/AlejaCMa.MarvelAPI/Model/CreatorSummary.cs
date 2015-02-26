using Newtonsoft.Json;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The summary view of a Creator
    /// </summary>
    public class CreatorSummary
    {
        /// <summary>
        /// Gets or sets the path to the individual creator resource
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// Gets or sets the full name of the creator
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role of the creator in the parent entity
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
