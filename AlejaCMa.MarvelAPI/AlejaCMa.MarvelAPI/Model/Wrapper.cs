using Newtonsoft.Json;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Results returned by the API endpoints have the same general format, no matter which entity type the endpoint returns. 
    /// Every successful call will return a wrapper object, which contains metadata about the call and a container object, 
    /// which displays pagination information and an array of the results returned by this call. 
    /// This pattern is consistent even if you are requesting a single object.
    /// </summary>
    /// <typeparam name="T">The type of the results returned by the call</typeparam>
    public class Wrapper<T>
    {
        /// <summary>
        /// Gets or sets the HTTP status code of the returned result
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the string description of the call status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the results returned by the call
        /// </summary>
        [JsonProperty("data")]
        public Container<T> Data { get; set; }

        /// <summary>
        /// Gets or sets the digest value of the content
        /// </summary>
        [JsonProperty("etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the copyright notice for the returned result
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the attribution notice for this result
        /// </summary>
        [JsonProperty("attributionText")]
        public string AttributionText { get; set; }

        /// <summary>
        /// Gets or sets the HTML representation of the attribution notice for this result
        /// </summary>
        [JsonProperty("attributionHTML")]
        public string AttributionHTML { get; set; }
    }
}
