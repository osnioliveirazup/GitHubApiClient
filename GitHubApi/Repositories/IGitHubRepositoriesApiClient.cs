using System.Collections.Generic;
using System.Threading.Tasks;
using GitHubApi.Repositories.Models;

namespace GitHubApi.Repositories
{
    public interface IGitHubRepositoriesApiClient
    {
        public Task<List<GetRepositoriesForUserResponse>> GetRepositoriesForUserAsync(string username);
    }
}
