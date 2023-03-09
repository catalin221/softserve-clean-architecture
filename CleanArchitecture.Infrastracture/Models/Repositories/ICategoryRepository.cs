using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models.Repositories
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }

        public void CreateCategory(Category Category);

        public void UpdateCategory(Category Category);

        public void DeleteCategory(Category Category);
    }
}
