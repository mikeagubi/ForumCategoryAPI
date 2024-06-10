using CategoryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryAPI.Data
{
    public class CategoryManager
    {
        private readonly MyDbContext _context;
        public CategoryManager(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategories()
        {
            List<Category> categories = await _context.Category.ToListAsync();
            return categories;
        }

        public async Task AddCategory(Category category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();
        }
    }
}
