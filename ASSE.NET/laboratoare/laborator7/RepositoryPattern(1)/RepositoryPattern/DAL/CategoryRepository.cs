using RepositoryPattern.Interfaces.DataAccess;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL
{
    class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public override void Delete(Category entityToDelete)
        {
            //base.Delete(entityToDelete);
        }
    }
}
