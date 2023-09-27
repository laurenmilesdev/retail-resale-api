using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RetailResaleApi.Context;
using RetailResaleApi.Data.Entities;
using RetailResaleApi.Interfaces;

namespace RetailResaleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionsController : ControllerBase
    {
        private readonly RetailResaleContext _context;
        private readonly IConditionService _conditionService;

        public ConditionsController(RetailResaleContext context, IConditionService conditionService)
        {
            _context = context;
            _conditionService = conditionService;
        }

        // GET: api/Conditions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condition>>> GetConditions()
        {
            var conditions = await _conditionService.GetConditions();

            return !conditions.IsNullOrEmpty() ? conditions.ToList() : NotFound();
        }

        // GET: api/Conditions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Condition>> GetCondition(int id)
        {
            var condition = await _conditionService.GetConditionById(id);

            return condition != null ? condition : NotFound();
        }

        private bool ConditionExists(int id)
        {
            return (_context.Condition?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
