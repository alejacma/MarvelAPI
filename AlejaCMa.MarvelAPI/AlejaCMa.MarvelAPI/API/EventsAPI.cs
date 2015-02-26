using System.Threading.Tasks;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Comics can also be a part of an event, which is a big, universe-changing storyline. 
    /// A comic's appearance in an event is often independent of its membership in a series.
    /// </summary>
    public class EventsAPI : BaseAPI
    {
        /// <summary>
        /// Initializes a new instance of the EventsAPI class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        public EventsAPI(IMarvelAPIConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// API: /v1/public/events.
        /// Fetches lists of events with optional filters.
        /// </summary>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of events</returns>
        public async Task<Wrapper<Event>> GetAllAsync(int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Event>("/v1/public/events", limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/events/{eventId}.
        /// This method fetches a single event resource. It is the canonical URI for any event resource provided by the API.
        /// </summary>
        /// <param name="eventId">The id of the event</param>
        /// <returns>The event</returns>
        public async Task<Wrapper<Event>> GetOneAsync(int eventId)
        {
            return await ExecuteRequestAsync<Event>(string.Format("/v1/public/events/{0}", eventId));
        }

        /// <summary>
        /// API: /v1/public/events/{eventId}/characters.
        /// Fetches lists of characters which appear in a specific event, with optional filters.
        /// </summary>
        /// <param name="eventId">The id of the event</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of characters</returns>
        public async Task<Wrapper<Character>> GetCharactersAsync(int eventId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Character>(string.Format("/v1/public/events/{0}/characters", eventId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/events/{eventId}/comics.
        /// Fetches lists of comics which take place during a specific event, with optional filters.
        /// </summary>
        /// <param name="eventId">The id of the event</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of comics</returns>
        public async Task<Wrapper<Comic>> GetComicsAsync(int eventId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Comic>(string.Format("/v1/public/events/{0}/comics", eventId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/events/{eventId}/creators.
        /// Fetches lists of comic creators whose work appears in a specific event, with optional filters.
        /// </summary>
        /// <param name="eventId">The id of the event</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of creators</returns>
        public async Task<Wrapper<Creator>> GetCreatorsAsync(int eventId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Creator>(string.Format("/v1/public/events/{0}/creators", eventId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/events/{eventId}/series.
        /// Fetches lists of comic series in which a specific event takes place, with optional filters. 
        /// </summary>
        /// <param name="eventId">The id of the event</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Series>> GetSeriesAsync(int eventId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Series>(string.Format("/v1/public/events/{0}/series", eventId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/events/{eventId}/stories.
        /// Fetches lists of comic series in which a specific event takes place, with optional filters. 
        /// </summary>
        /// <param name="eventId">The id of the event</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Story>> GetStoriesAsync(int eventId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Story>(string.Format("/v1/public/events/{0}/stories", eventId), limit, offset, filters);
        }
    }
}
