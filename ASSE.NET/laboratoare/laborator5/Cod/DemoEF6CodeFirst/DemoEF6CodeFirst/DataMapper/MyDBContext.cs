using DemoEF6CodeFirst.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF6CodeFirst.DataMapper
{
    public class MyDBContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyDBContext"/> class.
        /// </summary>
        public MyDBContext() : base("myConStr")
        {

        }

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
        /// <value>
        /// The customers.
        /// </value>
        public virtual DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public virtual DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>
        /// The orders.
        /// </value>
        public virtual DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public virtual DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the order lines.
        /// </summary>
        /// <value>
        /// The order lines.
        /// </value>
        public virtual DbSet<OrderLine> OrderLines { get; set; }

    }
}
