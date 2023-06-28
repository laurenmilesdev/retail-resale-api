namespace RetailResaleApi.Data.Entities
{
    public class SubCategory : BaseEntity
    {
        public Category Category { get; set; } = null!;
        public int CategoryId { get; set; }
        public string Value { get; set; } = null!;
    }
}
