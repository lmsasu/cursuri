using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF6CodeFirst.DomainModel
{
    public class Product
    {
        public int Id
        {
            get;
            set;
        }

        [Required(ErrorMessage = "The product category name cannot be null")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The length must be between 2 and 100")]
        public String Name
        {
            get; set;
        }

        [Required(ErrorMessage = "The category name cannot be null")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "The length must be between 2 and 10")]
        public string MeasurementUnit
        {
            get;
            set;
        }


        public decimal UnitPrice
        {
            get;
            set;
        }

        [Required]
        public Category Category
        {
            get;
            set;
        }
    }
}
