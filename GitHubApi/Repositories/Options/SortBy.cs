namespace GitHubApi.Repositories.Options
{
    public enum SortBy
    {
        CREATED,
        UPDATED,
        PUSHED,
        FULL_NAME,
        DEFAULT = FULL_NAME
    }

    public static class SortByExtensions
    {
        public static string NameAsString(this SortBy sb)
            => "sort";

        public static string ValueAsString(this SortBy sb)
            => sb.ToString().ToLower();
    }
}
