using System.Threading.Tasks;
using GitHubApi.Users.Models;

namespace GitHubApi.Users
{
    public interface IGitHubUsersApiClient
    {
        public Task<GetUserResponse> GetUserAsync(string username);
    }
}
