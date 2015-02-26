using System.Threading.Tasks;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Comics are made up of stories, which are indivisible components of comics. 
    /// Most comics have two stories - a cover and an interior story - but many, such as anthology comics and collections, 
    /// will have more. Stories may be re-published in several comics, but the comic in which they originally appeared 
    /// will always be present as a data point.
    /// </summary>
    public class StoriesAPI : BaseAPI
    {
        /// <summary>
        /// Initializes a new instance of the StoriesAPI class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        public StoriesAPI(IMarvelAPIConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// API: /v1/public/stories.
        /// Fetches lists of comic stories with optional filters.
        /// </summary>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of stories</returns>
        public async Task<Wrapper<Story>> GetAllAsync(int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Story>("/v1/public/stories", limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/stories/{storyId}.
        /// This method fetches a single comic story resource. It is the canonical URI for any comic story resource provided by the API.
        /// </summary>
        /// <param name="storyId">The id of the story</param>
        /// <returns>The story</returns>
        public async Task<Wrapper<Story>> GetOneAsync(int storyId)
        {
            return await ExecuteRequestAsync<Story>(string.Format("/v1/public/stories/{0}", storyId));
        }

        /// <summary>
        /// API: /v1/public/stories/{storyId}/characters.
        /// Fetches lists of comic characters appearing in a single story, with optional filters.
        /// </summary>
        /// <param name="storyId">The id of the story</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of characters</returns>
        public async Task<Wrapper<Character>> GetCharactersAsync(int storyId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Character>(string.Format("/v1/public/stories/{0}/characters", storyId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/stories/{storyId}/comics.
        /// Fetches lists of comics in which a specific story appears, with optional filters.
        /// </summary>
        /// <param name="storyId">The id of the story</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of comics</returns>
        public async Task<Wrapper<Comic>> GetComicsAsync(int storyId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Comic>(string.Format("/v1/public/stories/{0}/comics", storyId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/stories/{storyId}/creators.
        /// Fetches lists of comic creators whose work appears in a specific story, with optional filters.
        /// </summary>
        /// <param name="storyId">The id of the story</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of creators</returns>
        public async Task<Wrapper<Creator>> GetCreatorsAsync(int storyId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Creator>(string.Format("/v1/public/stories/{0}/creators", storyId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/stories/{storyId}/events.
        /// Fetches lists of events in which a specific story appears, with optional filters. 
        /// </summary>
        /// <param name="storyId">The id of the story</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Event>> GetEventsAsync(int storyId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Event>(string.Format("/v1/public/stories/{0}/events", storyId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/stories/{storyId}/series.
        /// Fetches lists of comic series in which the specified story takes place, with optional filters
        /// </summary>
        /// <param name="storyId">The id of the story</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Series>> GetSeriesAsync(int storyId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Series>(string.Format("/v1/public/stories/{0}/series", storyId), limit, offset, filters);
        }
    }
}
