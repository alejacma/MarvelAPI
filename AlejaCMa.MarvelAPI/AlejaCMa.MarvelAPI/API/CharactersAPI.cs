using System.Threading.Tasks;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The women, men, organizations, alien species, deities, animals, non-corporeal entities, trans-dimensional manifestations, 
    /// abstract personifications, and green amorphous blobs which occupy the Marvel Universe (and various alternate universes, 
    /// timelines and altered realities therein). For example, Spider-Man.
    /// </summary>
    public class CharactersAPI : BaseAPI
    {
        /// <summary>
        /// Initializes a new instance of the CharactersAPI class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        public CharactersAPI(IMarvelAPIConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// API: /v1/public/characters.
        /// Fetches lists of comic characters with optional filters.
        /// </summary>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of characters</returns>
        public async Task<Wrapper<Character>> GetAllAsync(int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Character>("/v1/public/characters", limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}.
        /// This method fetches a single character resource. It is the canonical URI for any character resource provided by the API.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <returns>The character</returns>
        public async Task<Wrapper<Character>> GetOneAsync(int characterId)
        {
            return await ExecuteRequestAsync<Character>(string.Format("/v1/public/characters/{0}", characterId));
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/comics.
        /// Fetches lists of comics containing a specific character, with optional filters.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of comics</returns>
        public async Task<Wrapper<Comic>> GetComicsAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Comic>(string.Format("/v1/public/characters/{0}/comics", characterId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/events.
        /// Fetches lists of events in which a specific character appears, with optional filters.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of events</returns>
        public async Task<Wrapper<Event>> GetEventsAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Event>(string.Format("/v1/public/characters/{0}/events", characterId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/series.
        /// Fetches lists of comic series in which a specific character appears, with optional filters.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Series>> GetSeriesAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Series>(string.Format("/v1/public/characters/{0}/series", characterId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/stories.
        /// Fetches lists of comic stories featuring a specific character with optional filters. 
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of stories</returns>
        public async Task<Wrapper<Story>> GetStoriesAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await ExecuteRequestAsync<Story>(string.Format("/v1/public/characters/{0}/stories", characterId), limit, offset, filters);
        }
    }
}
