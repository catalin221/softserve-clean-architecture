using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext _context;
        public IQueryable<Category> Categories => _context.Categories;

        public CategoryRepository(AppDbContext _context)
        {
            this._context = _context;
        }

        public void CreateCategory(Category Category)
        {
            this._context.Add(Category);
            this._context.SaveChanges();
        }

        public void DeleteCategory(Category Category)
        {
            this._context.Remove(Category);
            this._context.SaveChanges();
        }

        public void UpdateCategory(Category Category)
        {
            var retrieved = _context.Categories.FirstOrDefault(c => c.Id == Category.Id);

            if (retrieved != null)
            {
                retrieved.CategoryName = Category.CategoryName;
                retrieved.Books = Category.Books;
            }
            else
            {
                _context.Add(Category);
            }

            _context.SaveChanges();
        }
    }
}
