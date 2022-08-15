using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GitHubApi.Repositories.Models;

namespace GitHubApi.Repositories.Example
{
    public class GitHubRepositoriesApiClientExample
    {
        private readonly GitHubRepositoriesApiClient _client;

        public GitHubRepositoriesApiClientExample()
        {
            _client = new GitHubRepositoriesApiClient(new HttpClient());
        }

        public async Task<List<GetRepositoriesForUserResponse>> GetRepositoriesForUserAsync(string username)
        {
            // GitHub Api requires a valid User-Agent header to be sent
            // Suggestion is sending (registered) App name or GitHub username
            _client.UserAgent = username;

            return await _client.GetRepositoriesForUserAsync(username);
        }
    }
}
