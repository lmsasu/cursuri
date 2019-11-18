using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Interfaces.Bussiness
{
    interface ICategoryService : IService<Category>
    {
        IEnumerable<Category> GetCategoriesWithProducts();
    }
}
