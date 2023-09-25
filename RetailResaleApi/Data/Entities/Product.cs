using RetailResaleApi.Data.Enums;

namespace RetailResaleApi.Data.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Size { get; set; } = null!;
        public SizeType SizeType { get; set; }
        public Condition Condition { get; set; } = null!;
        public int ConditionId { get; set; }
        public bool IsSold { get; set; }
        public SubCategory SubCategory { get; set; } = null!;
        public int SubCategoryId { get; set; }
        public string? Brand { get; set; }
        public double? PurchasePrice { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public IEnumerable<ListingSiteProduct> ListingSiteProducts { get; set; } = null!;
    }
}
