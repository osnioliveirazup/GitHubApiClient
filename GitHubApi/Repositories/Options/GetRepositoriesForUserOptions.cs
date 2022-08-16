using System.Web;

namespace GitHubApi.Repositories.Options
{
    public class GetRepositoriesForUserOptions
    {
        public OwnershipType OwnershipType { get; set; }

        public SortBy SortBy { get; set; }

        private SortDirection _sortDirection;

        public SortDirection SortDirection
        {
            get
            {
                if (_sortDirection == SortDirection.DEFAULT)
                {
                    return (SortBy == SortBy.FULL_NAME) ? SortDirection.ASC : SortDirection.DESC;
                }

                return _sortDirection;
            }
            set
            {
                _sortDirection = value;
            }
        }

        public Pagination Pagination { get; set; }

        public GetRepositoriesForUserOptions()
        {
            OwnershipType = OwnershipType.DEFAULT;
            SortBy = SortBy.DEFAULT;
            SortDirection = SortDirection.DEFAULT;
            Pagination = Pagination.DefaultValues();
        }

        public static GetRepositoriesForUserOptions DefaultOptions()
            => new GetRepositoriesForUserOptions();

        public string ToQueryString()
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            queryString.Add(OwnershipType.NameAsString(), OwnershipType.ValueAsString());
            queryString.Add(SortBy.NameAsString(), SortBy.ValueAsString());
            queryString.Add(SortDirection.NameAsString(), SortDirection.ValueAsString());
            queryString.Add(Pagination.PerPageNameAsString(), Pagination.PerPageValueAsString());
            queryString.Add(Pagination.PageNameAsString(), Pagination.PageValueAsString());

            return queryString.ToString();
        }
    }
}
