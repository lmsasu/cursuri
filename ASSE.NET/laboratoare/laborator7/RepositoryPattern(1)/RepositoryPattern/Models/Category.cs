using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Category
    {
        public int Id
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        public string Description
        {
            get;
            set;
        }

        public ICollection<Product> Products
        {
            get;
            set;
        }
    }
}
