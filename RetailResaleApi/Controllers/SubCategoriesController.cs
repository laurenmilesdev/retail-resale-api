using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RetailResaleApi.Context;
using RetailResaleApi.Data.Entities;
using RetailResaleApi.Interfaces;

namespace RetailResaleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController : ControllerBase
    {
        private readonly RetailResaleContext _context;
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoriesController(RetailResaleContext context, ISubCategoryService subCategoryService)
        {
            _context = context;
            _subCategoryService = subCategoryService;
        }

        // GET: api/SubCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategory>>> GetSubCategories()
        {
            var subCategories = await _subCategoryService.GetSubCategories();

            return !subCategories.IsNullOrEmpty() ? subCategories.ToList() : NotFound();
        }

        // GET: api/SubCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategory>> GetSubCategory(int id)
        {
            var subCategory = await _subCategoryService.GetSubCategoryById(id);

            return subCategory != null ? subCategory : NotFound();
        }

        private bool SubCategoryExists(int id)
        {
            return (_context.SubCategory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
