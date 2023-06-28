using RetailResaleApi.Data.Entities.Interfaces;

namespace RetailResaleApi.Data.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
