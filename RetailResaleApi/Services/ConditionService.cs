using Microsoft.EntityFrameworkCore;
using RetailResaleApi.Context;
using RetailResaleApi.Data.Entities;
using RetailResaleApi.Interfaces;

namespace RetailResaleApi.Services
{
    public class ConditionService : BaseService, IConditionService
    {
        public ConditionService(RetailResaleContext dbContext) : base(dbContext) { }

        public async Task<Condition?> GetConditionById(int id)
        {
            var condition = await DbContext.Set<Condition>()
                .FirstOrDefaultAsync(ctx => ctx.Id == id);

            return condition;
        }

        public async Task<IEnumerable<Condition>> GetConditions()
        {
            var conditions = await DbContext.Set<Condition>()
                .ToListAsync();

            return conditions;
        }
    }
}
