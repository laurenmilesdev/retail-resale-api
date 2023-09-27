namespace RetailResaleApi.Data.Entities
{
    public class Category : BaseEntity
    {
        public string Value { get; set; } = null!;
        public ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
