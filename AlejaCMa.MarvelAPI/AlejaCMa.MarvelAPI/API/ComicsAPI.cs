using System.Threading.Tasks;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Comic issues (or just comics) are the physical or digital products that end-users read. 
    /// (The Marvel Comics API returns comic issues, collections, graphic novels and digital comics as part of the 
    /// overall comics endpoint and entity type.) 
    /// </summary>
    public class ComicsAPI : BaseAPI
    {
        /// <summary>
        /// Initializes a new instance of the ComicsAPI class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        public ComicsAPI(IMarvelAPIConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// API: /v1/public/comics.
        /// Fetches lists of comics with optional filters.
        /// </summary>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of comics</returns>
        public async Task<Wrapper<Comic>> GetAllAsync(int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Comic>("/v1/public/comics", limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/comics/{comicId}.
        /// This method fetches a single comic resource. It is the canonical URI for any comic resource provided by the API.
        /// </summary>
        /// <param name="comicId">The id of the comic</param>
        /// <returns>The comic</returns>
        public async Task<Wrapper<Comic>> GetOneAsync(int comicId)
        {
            return await ExecuteRequestAsync<Comic>(string.Format("/v1/public/comics/{0}", comicId));
        }

        /// <summary>
        /// API: /v1/public/comics/{comicId}/characters.
        /// Fetches lists of characters which appear in a specific comic with optional filters.
        /// </summary>
        /// <param name="comicId">The id of the comic</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of characters</returns>
        public async Task<Wrapper<Character>> GetCharactersAsync(int comicId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Character>(string.Format("/v1/public/comics/{0}/characters", comicId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/comics/{comicId}/creators.
        /// Fetches lists of comic creators whose work appears in a specific comic, with optional filters.
        /// </summary>
        /// <param name="comicId">The id of the comic</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of creators</returns>
        public async Task<Wrapper<Creator>> GetCreatorsAsync(int comicId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Creator>(string.Format("/v1/public/comics/{0}/creators", comicId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/comics/{comicId}/events.
        /// Fetches lists of events in which a specific comic appears, with optional filters.
        /// </summary>
        /// <param name="comicId">The id of the comic</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of events</returns>
        public async Task<Wrapper<Event>> GetEventsAsync(int comicId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Event>(string.Format("/v1/public/comics/{0}/events", comicId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/comics/{comicId}/stories.
        /// Fetches lists of comic stories in a specific comic issue, with optional filters. 
        /// </summary>
        /// <param name="comicId">The id of the comic</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of stories</returns>
        public async Task<Wrapper<Story>> GetStoriesAsync(int comicId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Story>(string.Format("/v1/public/comics/{0}/stories", comicId), limit, offset, filters);
        }
    }
}
