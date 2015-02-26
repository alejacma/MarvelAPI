using Newtonsoft.Json;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The price of a Comic
    /// </summary>
    public class ComicPrice
    {
        /// <summary>
        /// Gets or sets the description of the price(e.g.print price, digital price)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the price (all prices in USD)
        /// </summary>
        [JsonProperty("price")]
        public float Price { get; set; }
    }
}
