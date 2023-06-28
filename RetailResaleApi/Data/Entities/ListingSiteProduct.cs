namespace RetailResaleApi.Data.Entities
{
    public class ListingSiteProduct : BaseEntity
    {
        public Product Product { get; set; } = null!;
        public int ProductId { get; set; }
        public ListingSite ListingSite { get; set; } = null!;
        public int ListingSiteId { get; set; }
        public double ListedPrice { get; set; }
        public DateTime? DateListed { get; set; }
        public string? UrlToListing { get; set; } = null!;
    }
}
