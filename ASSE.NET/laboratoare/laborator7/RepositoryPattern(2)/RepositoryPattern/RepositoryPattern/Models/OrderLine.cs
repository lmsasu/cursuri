using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class OrderLine
    {
        public int Id { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public Order Order
        {
            get;
            set;
        }

        public decimal Price
        {
            get
            {
                return Product.UnitPrice * (decimal)Quantity;
            }
        }
    }
}
