using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GitHubApi.Repositories.Models;
using GitHubApi.Repositories.Options;

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

            var options = new GetRepositoriesForUserOptions
            {
                OwnershipType = OwnershipType.DEFAULT,
                SortBy = SortBy.UPDATED,
                SortDirection = SortDirection.ASC,
                Pagination = new Pagination
                {
                    PerPage = 5,
                    Page = 2
                }
            };

            return await _client.GetRepositoriesForUserAsync(username, options);
        }
    }
}
