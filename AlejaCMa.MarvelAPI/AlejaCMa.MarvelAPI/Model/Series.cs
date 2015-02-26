using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Comics belong to a series, which is a (usually) sequentially number list of comics with the same title and volume. 
    /// Marvel uses the year of original publication for a series as the volume number. 
    /// </summary>
    public class Series
    {
        /// <summary>
        /// Gets or sets the unique ID of the series resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the canonical title of the series
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the series
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

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
        /// Gets or sets the first year of publication for the series
        /// </summary>
        [JsonProperty("startYear")]
        public int StartYear { get; set; }

        /// <summary>
        /// Gets or sets the last year of publication for the series (conventionally, 2099 for ongoing series)
        /// </summary>
        [JsonProperty("endYear")]
        public int EndYear { get; set; }

        /// <summary>
        /// Gets or sets the age-appropriateness rating for the series
        /// </summary>
        [JsonProperty("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// Gets or sets the date the resource was most recently modified
        /// </summary>
        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or sets the representative image for this series
        /// </summary>
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing comics in this series
        /// </summary>
        [JsonProperty("comics")]
        public ResourceList<ComicSummary> Comics { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing stories which occur in comics in this series
        /// </summary>
        [JsonProperty("stories")]
        public ResourceList<StorySummary> Stories { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing events which take place in comics in this series
        /// </summary>
        [JsonProperty("events")]
        public ResourceList<EventSummary> Events { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing characters which appear in comics in this series
        /// </summary>
        [JsonProperty("characters")]
        public ResourceList<CharacterSummary> Characters { get; set; }

        /// <summary>
        /// Gets or sets the resource list of creators whose work appears in comics in this series
        /// </summary>
        [JsonProperty("creators")]
        public ResourceList<CreatorSummary> Creators { get; set; }

        /// <summary>
        /// Gets or sets the summary representation of the series which follows this series
        /// </summary>
        [JsonProperty("next")]
        public SeriesSummary Next { get; set; }

        /// <summary>
        /// Gets or sets the summary representation of the series which preceded this series
        /// </summary>
        [JsonProperty("previous")]
        public SeriesSummary Previous { get; set; }
    }
}
