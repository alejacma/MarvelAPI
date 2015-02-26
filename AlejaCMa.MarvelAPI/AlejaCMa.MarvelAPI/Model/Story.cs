using Newtonsoft.Json;
using System;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Comics are made up of stories, which are indivisible components of comics. 
    /// Most comics have two stories - a cover and an interior story - but many, such as anthology comics and collections, 
    /// will have more. Stories may be re-published in several comics, but the comic in which they originally appeared 
    /// will always be present as a data point.
    /// </summary>
    public class Story
    {
        /// <summary>
        /// Gets or sets the unique ID of the story resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the story title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the short description of the story
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the canonical URL identifier for this resource
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// Gets or sets the story type e.g.interior story, cover, text story
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the date the resource was most recently modified
        /// </summary>
        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or sets the representative image for this story
        /// </summary>
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing comics in which this story takes place
        /// </summary>
        [JsonProperty("comics")]
        public ResourceList<ComicSummary> Comics { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing series in which this story appears
        /// </summary>
        [JsonProperty("series")]
        public ResourceList<SeriesSummary> Series { get; set; }

        /// <summary>
        /// Gets or sets the resource list of the events in which this story appears
        /// </summary>
        [JsonProperty("events")]
        public ResourceList<EventSummary> Events { get; set; }

        /// <summary>
        /// Gets or sets the resource list of characters which appear in this story
        /// </summary>
        [JsonProperty("characters")]
        public ResourceList<CharacterSummary> Characters { get; set; }

        /// <summary>
        /// Gets or sets the resource list of creators who worked on this story
        /// </summary>
        [JsonProperty("creators")]
        public ResourceList<CreatorSummary> Creators { get; set; }

        /// <summary>
        /// Gets or sets the summary representation of the issue in which this story was originally published
        /// </summary>
        [JsonProperty("originalissue")]
        public ComicSummary OriginalIssue { get; set; }
    }
}
