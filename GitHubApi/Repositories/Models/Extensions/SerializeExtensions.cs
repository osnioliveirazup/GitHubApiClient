using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitHubApi.Repositories.Models.Extensions
{
    public static class SerializeExtensions
    {
        public static string ToJson(this List<GetRepositoriesForUserResponse> self)
            => JsonConvert.SerializeObject(self, GitHubApi.Repositories.Models.Settings.Converter.Settings);
    }
}
