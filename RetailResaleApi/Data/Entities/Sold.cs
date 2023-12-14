namespace RetailResaleApi.Data.Entities
{
    public class Sold : BaseEntity
    {
        public double SoldPrice { get; set; }
        public double? Fee { get; set; }
        public double? ShippingCost { get; set; }
        public DateTime? SoldDate { get; set; }
    }
}
