// /*
// * PROJECT:    JPS.Toolbox.RestApi
// * NAME:        RestClientAbstract.cs
// */

using System.Net.Http;
using System.Threading.Tasks;

namespace JPS.Toolbox.RestApi
{
    /// <summary>
    ///     TODO
    /// </summary>
    public class RestClientAbstract
    {
        #region Constructors

        public RestClientAbstract(string userAgent) { UserAgent = userAgent; }

        #endregion

        /// <summary>
        ///     Gets or sets the user agent used for requests
        /// </summary>
        /// <value>
        ///     The user agent.
        /// </value>
        public string UserAgent { get; set; }

        /// <summary>
        ///     TODO
        /// </summary>
        /// <param name="url">The URL. TODO</param>
        /// <returns></returns>
        public async Task<string> GetString(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Add(HttpRequestConstants.UserAgent, UserAgent);

                Task<string> stringTask = httpClient.GetStringAsync(url);
                string       response   = await stringTask;

                return response;
            }
        }
    }
}