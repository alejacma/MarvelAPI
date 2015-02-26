namespace AlejaCMa.MarvelAPI
{
    /// <summary>
    /// The information of your keys that you can get from https://developer.marvel.com/account
    /// </summary>
    public interface IMarvelAPIConfiguration
    {
        /// <summary>
        /// Your public key
        /// </summary>
        string PublicKey { get; }

        /// <summary>
        /// Your private key
        /// </summary>
        string PrivateKey { get;  }
    }
}
