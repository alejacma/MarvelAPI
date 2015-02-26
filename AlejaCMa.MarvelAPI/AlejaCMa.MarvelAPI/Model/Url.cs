using Newtonsoft.Json;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// URLs are references to web pages or deep links into applications. (When present in a resultset, it is preferred that you use 
    /// these to link back to Marvel.) Many resources will have more than one representation on the web so URLs are generally presented 
    /// as an array of URL resources.
    /// </summary>
    public class Url
    {
        /// <summary>
        /// Gets or sets the text identifier for the URL.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the full URL (including scheme, domain, and path)
        /// </summary>
        [JsonProperty("url")]
        public string FullUrl { get; set; }
    }
}
