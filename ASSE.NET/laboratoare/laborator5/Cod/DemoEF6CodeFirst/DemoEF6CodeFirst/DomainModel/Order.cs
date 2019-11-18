using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF6CodeFirst.DomainModel
{
    public class Order
    {
        public int Id
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        [Required]
        public Customer Customer
        {
            get;
            set;
        }

        public ICollection<OrderLine> Lines
        {
            get;
            set;
        }
    }
}
