using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// One of the women, men, organizations, alien species, deities, animals, non-corporeal entities, trans-dimensional manifestations, 
    /// abstract personifications, and green amorphous blobs which occupy the Marvel Universe (and various alternate universes, 
    /// timelines and altered realities therein). For example, Spider-Man.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Gets or sets the unique ID of the character resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the character
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short bio or description of the character
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date the resource was most recently modified
        /// </summary>
        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or sets the canonical URL identifier for this resource
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// Gets or sets the set of public web site URLs for the resource
        /// </summary>
        [JsonProperty("urls")]
        public List<Url> Urls { get; set; }

        /// <summary>
        /// Gets or sets the representative image for this character
        /// </summary>
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing comics which feature this character
        /// </summary>
        [JsonProperty("comics")]
        public ResourceList<ComicSummary> Comics { get; set; }

        /// <summary>
        /// Gets or sets the resource list of stories in which this character appears
        /// </summary>
        [JsonProperty("stories")]
        public ResourceList<StorySummary> Stories { get; set; }

        /// <summary>
        /// Gets or sets the resource list of events in which this character appears
        /// </summary>
        [JsonProperty("events")]
        public ResourceList<EventSummary> Events { get; set; }

        /// <summary>
        /// Gets or sets the resource list of series in which this character appears
        /// </summary>
        [JsonProperty("series")]
        public ResourceList<SeriesSummary> Series { get; set; }
    }
}
