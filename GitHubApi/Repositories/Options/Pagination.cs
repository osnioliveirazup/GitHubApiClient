namespace GitHubApi.Repositories.Options
{
    public class Pagination
    {
        public int PerPage { get; set; }

        public int Page { get; set; }

        public Pagination()
        {
            PerPage = 30;
            Page = 1;
        }

        public static Pagination DefaultValues()
            => new Pagination();

        public string PerPageNameAsString()
            => "per_page";

        public string PerPageValueAsString()
            => PerPage.ToString();

        public string PageNameAsString()
            => "page";

        public string PageValueAsString()
            => Page.ToString();
    }
}
