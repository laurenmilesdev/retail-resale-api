using RetailResaleApi.Data.Entities;

namespace RetailResaleApi.Interfaces
{
    public interface IConditionService
    {
        Task<Condition?> GetConditionById(int id);
        Task<IEnumerable<Condition>> GetConditions();
    }
}
