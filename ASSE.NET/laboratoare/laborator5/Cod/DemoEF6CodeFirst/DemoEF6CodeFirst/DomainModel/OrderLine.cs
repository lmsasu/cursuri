using System.ComponentModel.DataAnnotations;

namespace DemoEF6CodeFirst.DomainModel
{
    public class OrderLine
    {
        public int Id
        {
            get;
            set;
        }

        [Required]
        public Product Product
        {
            get;
            set;
        }

        [Required]
        public Order Order
        {
            get;
            set;
        }

        public double Quantity
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