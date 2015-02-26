using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Comics can also be a part of an event, which is a big, universe-changing storyline. 
    /// A comic's appearance in an event is often independent of its membership in a series.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets or sets the unique ID of the event resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the event
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the event
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }


        /// <summary>
        /// Gets or sets the canonical URL identifier for this resource
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// Gets or sets the set of public web site URLs for the event
        /// </summary>
        [JsonProperty("urls")]
        public List<Url> Urls { get; set; }

        /// <summary>
        /// Gets or sets the date the resource was most recently modified
        /// </summary>
        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or sets the date of publication of the first issue in this event
        /// </summary>
        [JsonProperty("start")]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or sets the date of publication of the last issue in this event
        /// </summary>
        [JsonProperty("end")]
        public DateTime? End { get; set; }

        /// <summary>
        /// Gets or sets the representative image for this event
        /// </summary>
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the comics in this event
        /// </summary>
        [JsonProperty("comics")]
        public ResourceList<ComicSummary> Comics { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the stories in this event
        /// </summary>
        [JsonProperty("stories")]
        public ResourceList<StorySummary> Stories { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the series in this event
        /// </summary>
        [JsonProperty("series")]
        public ResourceList<SeriesSummary> Series { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the characters which appear in this event
        /// </summary>
        [JsonProperty("characters")]
        public ResourceList<CharacterSummary> Characters { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing creators whose work appears in this event
        /// </summary>
        [JsonProperty("creators")]
        public ResourceList<CreatorSummary> Creators { get; set; }

        /// <summary>
        /// Gets or sets the summary representation of the event which follows this event
        /// </summary>
        [JsonProperty("next")]
        public EventSummary Next { get; set; }

        /// <summary>
        /// Gets or sets the summary representation of the event which preceded this event
        /// </summary>
        [JsonProperty("previous")]
        public EventSummary Previous { get; set; }
    }
}
