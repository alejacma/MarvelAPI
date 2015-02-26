using Newtonsoft.Json;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Text objects are bits of descriptive text which are attached to an entity.
    /// </summary>
    public class TextObject
    {
        /// <summary>
        /// Gets or sets the string description of the text object (e.g.solicit text, preview text, etc.)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the language code denoting which language the text object is written in
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the text of the text object
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
