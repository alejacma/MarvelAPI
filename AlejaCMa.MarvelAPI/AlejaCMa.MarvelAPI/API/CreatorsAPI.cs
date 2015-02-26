using System.Threading.Tasks;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Creators are the people and entities that make comics. 
    /// They are assigned to the specific comic stories on which they worked, 
    /// but we bubble up those assignments to the issues, series and events in which the stories appear as a convenience.
    /// </summary>
    public class CreatorsAPI : BaseAPI
    {
        /// <summary>
        /// Initializes a new instance of the CreatorsAPI class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        public CreatorsAPI(IMarvelAPIConfiguration configuration)
            : base(configuration)
        {
        }


        /// <summary>
        /// API: /v1/public/creators.
        /// Fetches lists of comic creators with optional filters.
        /// </summary>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of creators</returns>
        public async Task<Wrapper<Creator>> GetAllAsync(int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Creator>("/v1/public/creators", limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/creators/{creatorId}.
        /// This method fetches a single creator resource. It is the canonical URI for any creator resource provided by the API.
        /// </summary>
        /// <param name="creatorId">The id of the creator</param>
        /// <returns>The creator</returns>
        public async Task<Wrapper<Creator>> GetOneAsync(int creatorId)
        {
            return await ExecuteRequestAsync<Creator>(string.Format("/v1/public/creators/{0}", creatorId));
        }

        /// <summary>
        /// API: /v1/public/creators/{creatorId}/comics.
        /// Fetches lists of comics in which the work of a specific creator appears, with optional filters.
        /// </summary>
        /// <param name="creatorId">The id of the creator</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of comics</returns>
        public async Task<Wrapper<Comic>> GetComicsAsync(int creatorId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Comic>(string.Format("/v1/public/creators/{0}/comics", creatorId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/creators/{creatorId}/events.
        /// Fetches lists of events featuring the work of a specific creator with optional filters.
        /// </summary>
        /// <param name="creatorId">The id of the creator</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of events</returns>
        public async Task<Wrapper<Event>> GetEventsAsync(int creatorId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Event>(string.Format("/v1/public/creators/{0}/events", creatorId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/creators/{creatorId}/series.
        /// Fetches lists of comic series in which a specific creator's work appears, with optional filters.
        /// </summary>
        /// <param name="creatorId">The id of the creator</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Series>> GetSeriesAsync(int creatorId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Series>(string.Format("/v1/public/creators/{0}/series", creatorId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/creators/{creatorId}/stories.
        /// Fetches lists of comic stories by a specific creator with optional filters. 
        /// </summary>
        /// <param name="creatorId">The id of the creator</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of stories</returns>
        public async Task<Wrapper<Story>> GetStoriesAsync(int creatorId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Story>(string.Format("/v1/public/creators/{0}/stories", creatorId), limit, offset, filters);
        }
    }
}
