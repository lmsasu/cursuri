using RepositoryPattern.Interfaces.Bussiness;
using RepositoryPattern.Interfaces.DataAccess;
using RepositoryPattern.Models;
using RepositoryPattern.Startup;
using RepositoryPattern.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.BL
{
    class CategoryService : BaseService<Category, ICategoryRepository>, ICategoryService
    {
        public CategoryService()
            : base(Injector.Get<ICategoryRepository>(), new CategoryValidator())
        {
        }

        public IEnumerable<Category> GetCategoriesWithProducts()
        {
            return _repository.Get(
                filter: category => category.Products.Count > 0,
                includeProperties: "Products");
        }
    }
}
