using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Product
    {
        public int Id
        {
            get;
            set;
        }

        [Required(ErrorMessage = "The name cannot be null")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The length must be between 2 and 100")]
        public String Name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "The measurement unit cannot be null")]
        [StringLength(20, ErrorMessage = "The measurement unit must be at most 20 chars")]
        public string MeasurementUnit
        {
            get;
            set;
        }

        [Required]
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
