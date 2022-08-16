namespace GitHubApi.Repositories.Options
{
    public enum OwnershipType
    {
        ALL,
        OWNER,
        MEMBER,
        DEFAULT = OWNER
    }

    public static class OwnershipTypeExtensions
    {
        public static string NameAsString(this OwnershipType ot)
            => "type";

        public static string ValueAsString(this OwnershipType ot)
            => ot.ToString().ToLower();
    }
}
