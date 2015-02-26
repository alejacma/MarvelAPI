using System.Threading.Tasks;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Comics belong to a series, which is a (usually) sequentially number list of comics with the same title and volume. 
    /// Marvel uses the year of original publication for a series as the volume number. 
    /// </summary>
    public class SeriesAPI : BaseAPI
    {
        /// <summary>
        /// Initializes a new instance of the SeriesAPI class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        public SeriesAPI(IMarvelAPIConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// API: /v1/public/series.
        /// Fetches lists of comic series with optional filters.
        /// </summary>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Series>> GetAllAsync(int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Series>("/v1/public/series", limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/series/{seriesId}.
        /// This method fetches a single comic series resource. It is the canonical URI for any comic series resource provided by the API.
        /// </summary>
        /// <param name="seriesId">The id of the series</param>
        /// <returns>The event</returns>
        public async Task<Wrapper<Series>> GetOneAsync(int seriesId)
        {
            return await ExecuteRequestAsync<Series>(string.Format("/v1/public/series/{0}", seriesId));
        }

        /// <summary>
        /// API: /v1/public/series/{seriesId}/characters.
        /// Fetches lists of characters which appear in a specific event, with optional filters.
        /// </summary>
        /// <param name="seriesId">The id of the series</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of characters</returns>
        public async Task<Wrapper<Character>> GetCharactersAsync(int seriesId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Character>(string.Format("/v1/public/series/{0}/characters", seriesId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/series/{seriesId}/comics.
        /// Fetches lists of comics which are published as part of a specific series, with optional filters.
        /// </summary>
        /// <param name="seriesId">The id of the series</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of comics</returns>
        public async Task<Wrapper<Comic>> GetComicsAsync(int seriesId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Comic>(string.Format("/v1/public/series/{0}/comics", seriesId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/series/{seriesId}/creators. 
        /// Fetches lists of comic creators whose work appears in a specific series, with optional filters.
        /// </summary>
        /// <param name="seriesId">The id of the series</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of creators</returns>
        public async Task<Wrapper<Creator>> GetCreatorsAsync(int seriesId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Creator>(string.Format("/v1/public/series/{0}/creators", seriesId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/series/{seriesId}/events.
        /// Fetches lists of events which occur in a specific series, with optional filters. 
        /// </summary>
        /// <param name="seriesId">The id of the series</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Event>> GetEventsAsync(int seriesId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Event>(string.Format("/v1/public/series/{0}/events", seriesId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/series/{seriesId}/stories.
        /// Fetches lists of comic stories from a specific series with optional filters. 
        /// </summary>
        /// <param name="seriesId">The id of the series</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Story>> GetStoriesAsync(int seriesId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Story>(string.Format("/v1/public/series/{0}/stories", seriesId), limit, offset, filters);
        }
    }
}
