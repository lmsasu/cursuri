using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Customer
    {
        public int Id
        {
            get;
            set;
        }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name
        {
            get;
            set;
        }

        [StringLength(200)]
        public string Address
        {
            get;
            set;
        }
    }
}
