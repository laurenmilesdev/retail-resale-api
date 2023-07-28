using RetailResaleApi.Context;

namespace RetailResaleApi.Services
{
    public abstract class BaseService
    {
        protected readonly RetailResaleContext DbContext;

        protected BaseService(RetailResaleContext dbContext) { DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext)); }
    }
}
