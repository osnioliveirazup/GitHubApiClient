using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GitHubApi.Users.Config;
using GitHubApi.Users.Models;

namespace GitHubApi.Users
{
    public class GitHubUsersApiClient : IGitHubUsersApiClient
    {
        private readonly HttpClient _httpClient;

        public string UserAgent { get; set; } = GitHubUsersApiClientConfiguration.DefaultUserAgent;

        public GitHubUsersApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

            _httpClient.BaseAddress = new Uri(GitHubUsersApiClientConfiguration.BaseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github+json")
            );
        }

        //
        // Documentation:
        // https://docs.github.com/en/rest/users/users#get-a-user
        //
        // Notes:
        //   Does not implement (yet) the "Response with GitHub plan information"
        //   - would require authentication with the "Plan" user permission
        //   See documentation for details
        //
        public async Task<GetUserResponse> GetUserAsync(string username)
        {
            var endpoint = string.Format(GitHubUsersApiClientConfiguration.GetUserEndpoint, username);

            using (var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, endpoint))
            {
                // GitHub Api requires a valid User-Agent header to be sent
                // Suggestion is sending (registered) App name or GitHub username
                httpRequestMessage.Headers.Add("User-Agent", UserAgent);

                using (var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage))
                {
                    httpResponseMessage.EnsureSuccessStatusCode();
                    return await httpResponseMessage.Content.ReadAsAsync<GetUserResponse>();
                }
            }
        }
    }
}
