using System;
using System.Net.Http;
using System.Threading.Tasks;
using GitHubApi.Users.Example;

namespace GitHubApiClientExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            var username = "octocat";
            var gitHubUsersApiClientExample = new GitHubUsersApiClientExample();

            try
            {
                var user = await gitHubUsersApiClientExample.GetUserAsync(username);
                Console.WriteLine($"User login: {user.Login}");
                Console.WriteLine($"User name: {user.Name}");
                Console.WriteLine($"Repositories URL: {user.ReposUrl}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error getting user {username} from GitHub: {(int)ex.StatusCode} ({ex.StatusCode})");
            }
        }
    }
}
