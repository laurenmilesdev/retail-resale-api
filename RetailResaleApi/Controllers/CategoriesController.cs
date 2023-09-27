using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RetailResaleApi.Context;
using RetailResaleApi.Data.Entities;
using RetailResaleApi.Interfaces;

namespace RetailResaleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly RetailResaleContext _context;
        private readonly ICategoryService _categoryService;

        public CategoriesController(RetailResaleContext context, ICategoryService categoryService)
        {
            _context = context;
            _categoryService = categoryService;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var categories = await _categoryService.GetCategories();

            return !categories.IsNullOrEmpty() ? categories.ToList() : NotFound();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _categoryService.GetCategoryById(id);

            return category != null ? category : NotFound();
        }

        private bool CategoryExists(int id)
        {
            return (_context.Category?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
