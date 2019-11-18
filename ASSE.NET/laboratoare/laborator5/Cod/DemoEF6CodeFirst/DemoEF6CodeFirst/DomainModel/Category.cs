using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoEF6CodeFirst.DomainModel
{
    public class Category
    {
        public int Id
        {
            get;
            set;
        }

        [Required(ErrorMessage = "The category name cannot be null")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The length must be between 2 and 100")]
        public string Name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "The category name cannot be null")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "The length must be between 2 and 150")]
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