using System.Net.Http;
using System.Threading.Tasks;
using GitHubApi.Users.Models;

namespace GitHubApi.Users.Example
{
    public class GitHubUsersApiClientExample
    {
        private readonly GitHubUsersApiClient _client;

        public GitHubUsersApiClientExample()
        {
            _client = new GitHubUsersApiClient(new HttpClient());
        }

        public async Task<GetUserResponse> GetUserAsync(string username)
        {
            // GitHub Api requires a valid User-Agent header to be sent
            // Suggestion is sending (registered) App name or GitHub username
            _client.UserAgent = username;

            return await _client.GetUserAsync(username);
        }
    }
}
