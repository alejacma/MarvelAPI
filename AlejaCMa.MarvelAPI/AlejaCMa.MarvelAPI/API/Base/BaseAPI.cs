using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// Any classes that would like to make requests to the Marvel API should inherit from this one
    /// </summary>
    public abstract class BaseAPI
    {
        private string baseUri = "http://gateway.marvel.com";
        private string publicKey;
        private string privateKey;

        /// <summary>
        /// Initializes a new instance of the BaseAPI class
        /// </summary>
        /// <param name="configuration">The configuration of the Marvel API</param>
        protected BaseAPI(IMarvelAPIConfiguration configuration)
        {
            publicKey = configuration.PublicKey;
            privateKey = configuration.PrivateKey;
        }

        /// <summary>
        /// Gets a timestamp (or other long string which can change on a request-by-request basis)
        /// </summary>
        /// <returns>The timestamp</returns>
        private string GetTimeStamp()
        {
            return DateTime.UtcNow.Ticks.ToString();
        }

        /// <summary>
        /// Gets a MD5 hash of the timestamp, the private key and the public key
        /// </summary>
        /// <param name="ts">TimeStamp</param>
        /// <param name="privateKey">Private Key</param>
        /// <param name="publicKey">Public Key</param>
        /// <returns>The hash</returns>
        private string GetHash(string ts, string privateKey, string publicKey)
        {
            string toHash = string.Format("{0}{1}{2}", ts, privateKey, publicKey);

            MD5Digest digest = new MD5Digest();
            byte[] bytes = Encoding.UTF8.GetBytes(toHash);
            digest.BlockUpdate(bytes, 0, bytes.Length);

            int digestSize = digest.GetDigestSize();
            byte[] hash = new byte[digestSize];
            digest.DoFinal(hash, 0);

            return BitConverter.ToString(hash).Replace("-", String.Empty).ToLower();
        }

        /// <summary>
        /// Executes a request to the Marvel API 
        /// http://developer.marvel.com/documentation/authorization
        /// </summary>
        /// <typeparam name="T">The type of the expected results</typeparam>
        /// <param name="api">The API to call</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>A wrapper object, which contains metadata about the call and a container object, which displays pagination information and an array of the results returned by this call</returns>
        protected async Task<Wrapper<T>> ExecuteRequestAsync<T>(string api, int? limit = null, int? offset = null, IEnumerable<APIFilter> filters = null)
        {
            string timeStamp = GetTimeStamp();
            var parameters = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("ts", timeStamp),
                new KeyValuePair<string, string>("apikey", publicKey),
                new KeyValuePair<string, string>("hash", GetHash(timeStamp, privateKey, publicKey))
            };
            if (limit.HasValue)
            {
                if (limit.Value < 1 || limit.Value > 100)
                {
                    throw new ArgumentException("Value must be between 1 and 100", "limit");
                }
                parameters.Add(new KeyValuePair<string, string>("limit", limit.Value.ToString()));
            }
            if (offset.HasValue)
            {
                if (offset.Value < 0)
                {
                    throw new ArgumentException("Value must not be negative", "offset");
                }
                parameters.Add(new KeyValuePair<string, string>("offset", offset.Value.ToString()));
            }
            if (filters != null)
            {
                parameters.AddRange(filters.Select(filter => filter.Filter));
            }

            string query;
            using (var content = new FormUrlEncodedContent(parameters))
            {
                query = await content.ReadAsStringAsync();
            }

            using (HttpClient httpClient = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Format("{0}{1}?{2}", baseUri, api, query));
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Wrapper<T>>(content, new JsonSerializerSettings
                {
                    Error = (sender, args) =>
                    {
                        args.ErrorContext.Handled = true;
                    }
                });
            }
        }
    }
}
