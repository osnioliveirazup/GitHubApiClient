namespace GitHubApi.Repositories.Config
{
    public static class GitHubRepositoriesApiClientConfiguration
    {
        public const string DefaultUserAgent = "StackSpot GitHub Repositories Api plugin"; // Unregistered!

        public const string BaseUrl = "https://api.github.com/";

        public const string GetRepositoriesForUserEndpoint = "users/{0}/repos"; // GET /users/{username}/repos
    }
}
