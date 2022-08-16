namespace GitHubApi.Repositories.Options
{
    public enum SortDirection
    {
        ASC,
        DESC,
        DEFAULT // asc if "sort=full_name", desc otherwise
    }

    public static class SortDirectionExtensions
    {
        public static string NameAsString(this SortDirection sd)
            => "direction";

        public static string ValueAsString(this SortDirection sd)
            => sd.ToString().ToLower();
    }
}
