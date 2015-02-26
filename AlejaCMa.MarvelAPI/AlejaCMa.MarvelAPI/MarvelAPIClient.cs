namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The client of the Marvel API
    /// </summary>
    public class MarvelAPIClient
    {
        /// <summary>
        /// Gets characters
        /// </summary>
        public CharactersAPI Characters { get; private set; }

        /// <summary>
        /// Gets comics
        /// </summary>
        public ComicsAPI Comics { get; private set; }

        /// <summary>
        /// Gets creators
        /// </summary>
        public CreatorsAPI Creators { get; private set; }

        /// <summary>
        /// Gets events
        /// </summary>
        public EventsAPI Events { get; private set; }

        /// <summary>
        /// Gets series
        /// </summary>
        public SeriesAPI Series { get; private set; }

        /// <summary>
        /// Gets stories
        /// </summary>
        public StoriesAPI Stories { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MarvelAPIClient class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        public MarvelAPIClient(IMarvelAPIConfiguration configuration)
        {
            Characters = new CharactersAPI(configuration);
            Comics = new ComicsAPI(configuration);
            Creators = new CreatorsAPI(configuration);
            Events = new EventsAPI(configuration);
            Series = new SeriesAPI(configuration);
            Stories = new StoriesAPI(configuration);
        }
    }
}
