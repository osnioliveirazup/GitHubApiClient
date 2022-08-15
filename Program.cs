using System;
using System.Net.Http;
using System.Threading.Tasks;
using GitHubApi.Repositories.Example;

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
            var gitHubRepositoriesApiClientExample = new GitHubRepositoriesApiClientExample();

            try
            {
                var repositories = await gitHubRepositoriesApiClientExample.GetRepositoriesForUserAsync(username);

                foreach (var repository in repositories)
                {
                    Console.WriteLine($"Repository name: {repository.Name}");
                    Console.WriteLine($"Repository owner: {repository.Owner.Login}");
                    Console.WriteLine($"Repository URL: {repository.Url}");
                    Console.WriteLine("---");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error getting repositories for user {username} from GitHub: {(int)ex.StatusCode} ({ex.StatusCode})");
            }
        }
    }
}
