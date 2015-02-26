using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// One of the optional filters that we can pass to the API. 
    /// Check out the documentation of the API (http://developer.marvel.com/docs) 
    /// for details on the name of the filters and the accepted values 
    /// </summary>
    public class APIFilter
    {
        /// <summary>
        /// The filter
        /// </summary>
        public KeyValuePair<string, string> Filter { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the APIFilter class
        /// </summary>
        /// <param name="name">The name of the filter</param>
        /// <param name="value">The value to filter by</param>
        public APIFilter(string name, string value)
        {
            Filter = new KeyValuePair<string, string>(name, value);
        }

        /// <summary>
        /// Initializes a new instance of the APIFilter class
        /// </summary>
        /// <param name="name">The name of the filter</param>
        /// <param name="value">The value to filter by</param>
        public APIFilter(string name, DateTime value)
        {
            Filter = new KeyValuePair<string, string>(name, JsonConvert.SerializeObject(value));
        }

        /// <summary>
        /// Initializes a new instance of the APIFilter class
        /// </summary>
        /// <param name="name">The name of the filter</param>
        /// <param name="value">The value to filter by</param>
        public APIFilter(string name, int value)
        {
            Filter = new KeyValuePair<string, string>(name, value.ToString());
        }

        /// <summary>
        /// Initializes a new instance of the APIFilter class
        /// </summary>
        /// <param name="name">The name of the filter</param>
        /// <param name="value">The value to filter by</param>
        public APIFilter(string name, bool value)
        {
            Filter = new KeyValuePair<string, string>(name, value.ToString());
        }

        /// <summary>
        /// Initializes a new instance of the APIFilter class
        /// </summary>
        /// <param name="name">The name of the filter</param>
        /// <param name="rangeStart">The start value of the range to filter by</param>
        /// <param name="rangeEnd">The end value of the range to filter by</param>
        public APIFilter(string name, DateTime rangeStart, DateTime rangeEnd)
        {
            Filter = new KeyValuePair<string, string>(
                name,
                string.Format("{0},{1}", JsonConvert.SerializeObject(rangeStart), JsonConvert.SerializeObject(rangeEnd)));
        }

        /// <summary>
        /// Initializes a new instance of the APIFilter class
        /// </summary>
        /// <param name="name">The name of the filter</param>
        /// <param name="values">The list of values to filter by</param>
        public APIFilter(string name, params string[] values)
        {
            Filter = new KeyValuePair<string, string>(name, string.Join(",", values));
        }

        /// <summary>
        /// Initializes a new instance of the APIFilter class
        /// </summary>
        /// <param name="name">The name of the filter</param>
        /// <param name="values">The list of values to filter by</param>
        public APIFilter(string name, params int[] values)
        {
            Filter = new KeyValuePair<string, string>(name, string.Join(",", values.Select(v => v.ToString())));
        }
    }
}
