using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Resource lists are collections of summary views within the context of another entity type. 
    /// For example, the list of creators attached to a comic would be presented as resource list inside the full 
    /// representation of that comic.
    /// </summary>
    public class ResourceList<T>
    {
        /// <summary>
        /// Gets or sets the number of total available resources in this list
        /// </summary>
        [JsonProperty("available")]
        public int Available { get; set; }

        /// <summary>
        /// Gets or sets the number of resources returned in this resource list (up to 20)
        /// </summary>
        [JsonProperty("returned")]
        public int Returned { get; set; }

        /// <summary>
        /// Gets or sets the path to the list of full view representations of the items in this resource list
        /// </summary>
        [JsonProperty("collectionURI")]
        public string CollectionURI { get; set; }

        /// <summary>
        /// Gets or sets the list of summary views of the items in this resource list
        /// </summary>
        [JsonProperty("items")]
        public List<T> Items { get; set; }
    }
}
