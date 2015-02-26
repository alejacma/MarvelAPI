using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// One of the comic issues (or just comics) that are the physical or digital products that end-users read. 
    /// (The Marvel Comics API returns comic issues, collections, graphic novels and digital comics as part of the 
    /// overall comics endpoint and entity type.) 
    /// </summary>
    public class Comic
    {
        /// <summary>
        /// Gets or sets the unique ID of the comic resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the digital comic representation of this comic.
        /// Will be 0 if the comic is not available digitally
        /// </summary>
        [JsonProperty("digitalId")]
        public int DigitalId { get; set; }

        /// <summary>
        /// Gets or sets the canonical title of the comic
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the number of the issue in the series (will generally be 0 for collection formats)
        /// </summary>
        [JsonProperty("issueNumber")]
        public double IssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the text description of the variant 
        /// if the issue is a variant (e.g.an alternate cover, second printing, or director's cut)
        /// </summary>
        [JsonProperty("variantDescription")]
        public string VariantDescription { get; set; }

        /// <summary>
        /// Gets or sets the preferred description of the comic
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date the resource was most recently modified
        /// </summary>
        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or sets the ISBN for the comic (generally only populated for collection formats)
        /// </summary>
        [JsonProperty("isbn")]
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the UPC barcode number for the comic(generally only populated for periodical formats)
        /// </summary>
        [JsonProperty("upc")]
        public string UPC { get; set; }

        /// <summary>
        /// Gets or sets the Diamond code for the comic
        /// </summary>
        [JsonProperty("diamondCode")]
        public string DiamondCode { get; set; }

        /// <summary>
        /// Gets or sets the EAN barcode for the comic
        /// </summary>
        [JsonProperty("ean")]
        public string EAN { get; set; }

        /// <summary>
        /// Gets or sets the ISSN barcode for the comic
        /// </summary>
        [JsonProperty("issn")]
        public string ISSN { get; set; }

        /// <summary>
        /// Gets or sets the publication format of the comic e.g.comic, hardcover, trade paperback
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the number of story pages in the comic
        /// </summary>
        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        /// <summary>
        /// Gets or sets the set of descriptive text blurbs for the comic
        /// </summary>
        [JsonProperty("textObjects")]
        public List<TextObject> TextObjects { get; set; }

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
        /// Gets or sets the summary representation of the series to which this comic belongs
        /// </summary>
        [JsonProperty("series")]
        public SeriesSummary Series { get; set; }

        /// <summary>
        /// Gets or sets the list of variant issues for this comic (includes the "original" issue if the current issue is a variant)
        /// </summary>
        [JsonProperty("variants")]
        public List<ComicSummary> Variants { get; set; }

        /// <summary>
        /// Gets or sets the list of collections which include this comic (will generally be empty if the comic's format is a collection)
        /// </summary>
        [JsonProperty("collections")]
        public List<ComicSummary> Collections { get; set; }

        /// <summary>
        /// Gets or sets the list of issues collected in this comic (will generally be empty for periodical formats such as "comic" or "magazine")
        /// </summary>
        [JsonProperty("collectedIssues")]
        public List<ComicSummary> CollectedIssues { get; set; }

        /// <summary>
        /// Gets or sets the list of key dates for this comic
        /// </summary>
        [JsonProperty("dates")]
        public List<ComicDate> Dates { get; set; }

        /// <summary>
        /// Gets or sets the list of prices for this comic
        /// </summary>
        [JsonProperty("prices")]
        public List<ComicPrice> Prices { get; set; }

        /// <summary>
        /// Gets or sets the representative image for this comic
        /// </summary>
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the list of promotional images associated with this comic
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the creators associated with this comic
        /// </summary>
        [JsonProperty("creators")]
        public ResourceList<CreatorSummary> Creators { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the characters which appear in this comic
        /// </summary>
        [JsonProperty("characters")]
        public ResourceList<CharacterSummary> Characters { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the stories which appear in this comic
        /// </summary>
        [JsonProperty("stories")]
        public ResourceList<StorySummary> Stories { get; set; }

        /// <summary>
        /// Gets or sets the resource list containing the events in which this comic appears
        /// </summary>
        [JsonProperty("events")]
        public ResourceList<EventSummary> Events { get; set; }
    }
}
