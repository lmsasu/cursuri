using RepositoryPattern.DAL;
using RepositoryPattern.DataMapper;
using RepositoryPattern.Interfaces.DataAccess;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init
            //using (MyContext myContext = new MyContext())
            //{
            //    myContext.Customers.ToList().ForEach(Console.WriteLine);
            //}

            // Test DAL
            // Works
            ICategoryRepository categoryRepo = new CategoryRepository();
            var items = categoryRepo.Get(
                filter: exp => exp.Id == 1,
                orderBy: q => q.OrderBy(c => c.Name), 
                includeProperties: "Products");


            foreach (var item in items)
            {
                //Console.WriteLine(item.Products.Count.ToString());
                Console.WriteLine(item.Products.Count.ToString());
            }
            
            //items.Select(i => i.Products.Count).ToList().ForEach(Console.WriteLine);

            var category = new Category()
            {
                Name = "Test",
                Description = "N/A",
                Products = new List<Product>() 
                { 
                    new Product() { Name= "myTestedProduct", UnitPrice = 20, MeasurementUnit = "CC" }
                }
            };
            // Works - works
            categoryRepo.Insert(category);

            // Update - works
            category.Name = "Modified!";
            categoryRepo.Update(category);

            //Delete - works
            categoryRepo.Delete(category);

            Console.ReadKey(true);
        }
    }
}
