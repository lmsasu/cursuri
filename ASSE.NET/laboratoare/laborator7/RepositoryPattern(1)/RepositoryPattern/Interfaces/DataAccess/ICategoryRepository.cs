using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Interfaces.DataAccess
{
    interface ICategoryRepository : IRepository<Category>
    {
    }
}
