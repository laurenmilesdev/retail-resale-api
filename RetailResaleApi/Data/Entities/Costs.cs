namespace RetailResaleApi.Data.Entities
{
    public class Costs : BaseEntity
    {
        public double PurchasePrice { get; set; }
        public double? Fee { get; set; }
        public double? Shipping { get; set; }
    }
}
