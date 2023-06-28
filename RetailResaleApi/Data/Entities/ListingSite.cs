namespace RetailResaleApi.Data.Entities
{
    public class ListingSite : BaseEntity
    {
        public string SiteName { get; set; } = null!;
        public string? Url { get; set; } = null!;

        public IEnumerable<ListingSiteProduct> ListingSiteProducts { get; set; } = null!;
    }
}
