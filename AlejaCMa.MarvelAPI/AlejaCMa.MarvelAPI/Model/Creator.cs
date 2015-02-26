using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// One of the creators that are the people and entities that make comics. 
    /// They are assigned to the specific comic stories on which they worked, 
    /// but we bubble up those assignments to the issues, series and events in which the stories appear as a convenience.
    /// </summary>
    public class Creator
    {
        /// <summary>
        /// Gets or sets the unique ID of the creator resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the creator
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name of the creator
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the creator
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the suffix or honorific for the creator
        /// </summary>
        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the full name of the creator (a space-separated concatenation of the above four fields)
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

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
        /// Gets or sets the representative image for this creator
        /// </summary>
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the series which feature work by this creator
        /// </summary>
        [JsonProperty("series")]
        public ResourceList<SeriesSummary> Series { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the stories which feature work by this creator
        /// </summary>
        [JsonProperty("stories")]
        public ResourceList<StorySummary> Stories { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the comics which feature work by this creator
        /// </summary>
        [JsonProperty("comics")]
        public ResourceList<ComicSummary> Comics { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the events which feature work by this creator
        /// </summary>
        [JsonProperty("events")]
        public ResourceList<EventSummary> Events { get; set; }

    }
}
