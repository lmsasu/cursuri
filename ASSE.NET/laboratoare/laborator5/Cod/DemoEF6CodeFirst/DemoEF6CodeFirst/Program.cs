using DemoEF6CodeFirst.DataMapper;
using DemoEF6CodeFirst.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF6CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //addProduct();

            //listAllProducts();

            addOrder();
        }

        private static void addOrder()
        {
            using (var context = new MyDBContext())
            {
                var customer = new Customer
                {
                    Name = "A customer",
                    Address = "Brasov"
                };

                var product = context.Products.Where(prod => prod.Name == "Paine").SingleOrDefault();

                if (product != null)
                {
                    var order = new Order
                    {
                        Customer = customer,
                        Date = DateTime.Now,
                        Lines = new List<OrderLine> { new OrderLine { Product = product, Quantity = 5 } }
                    };
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
        }

        private static void listAllProducts()
        {
            Console.WriteLine("Inside listAllProducts:");
            using (var context = new MyDBContext())
            {
                var allProducts = context.Products.OrderBy(prod => prod.Name);
                foreach (var item in allProducts)
                {
                    Console.WriteLine("{0} {1}", item.Name, item.UnitPrice.ToString());
                }
            }
        }

        private static void addProduct()
        {
            using (var context = new MyDBContext())
            {
                Product product = new Product
                {
                    Name = "Paine",
                    MeasurementUnit = "Bucata",
                    UnitPrice = 3.0M,
                    Category = new Category
                    {
                        Name = "Aliment",
                        Description = "Descriere",
                    }
                };

                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
