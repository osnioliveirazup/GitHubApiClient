using System.Collections.Generic;
using System.Threading.Tasks;
using GitHubApi.Repositories.Models;
using GitHubApi.Repositories.Options;

namespace GitHubApi.Repositories
{
    public interface IGitHubRepositoriesApiClient
    {
        public Task<List<GetRepositoriesForUserResponse>> GetRepositoriesForUserAsync(string username);

        public Task<List<GetRepositoriesForUserResponse>> GetRepositoriesForUserAsync(string username, GetRepositoriesForUserOptions options);
    }
}
