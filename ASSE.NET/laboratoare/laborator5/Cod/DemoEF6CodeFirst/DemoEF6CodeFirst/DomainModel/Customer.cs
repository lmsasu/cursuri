using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF6CodeFirst.DomainModel
{
    public class Customer
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

        [StringLength(300, MinimumLength = 2, ErrorMessage = "The length must be between 2 and 300")]
        public string Address
        {
            get;
            set;
        }
    }
}
