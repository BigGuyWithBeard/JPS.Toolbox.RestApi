// /*
// * PROJECT:    JPS.Toolbox.RestApi
// * NAME:        Class1.cs
// */

using System.Threading.Tasks;

namespace JPS.Toolbox.RestApi
{
    /// <summary>
    ///     TODO
    /// </summary>
    public interface IRestClient
    {
        /// <summary>
        ///     Gets or sets the user agent used by the RestClient
        /// </summary>
        /// <value>
        ///     The user agent.
        /// </value>
        string UserAgent { get; set; }

        /// <summary>
        ///     TODO
        /// </summary>
        /// <param name="url">The URL TODO</param>
        /// <returns></returns>
        Task<string> GetString(string url);
    }
}