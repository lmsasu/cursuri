using System;
using System.Collections.Generic;
using DemoEF6CodeFirst.DomainModel;
using System.Linq;

namespace DataMapper.SqlServerDAO
{
    internal class SQLProductDataServices : IProductDataServices
    {
        /// <summary>
        /// Adds the product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void AddProduct(Product product)
        {
            using (var context = new MyApplicationContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes the product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void DeleteProduct(Product product)
        {
            //see the approaches from http://stackoverflow.com/questions/8391520/entity-framework-how-do-i-delete-a-record-by-its-primary-key
            using (var context = new MyApplicationContext())
            {
                var newProd = new Product { Id = product.Id };
                context.Products.Attach(newProd);
                context.Products.Remove(newProd);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public IList<Product> GetAllProducts()
        {
            using (var context = new MyApplicationContext())
            {
                return context.Products.Select(product => product).ToList();
            }
        }

        /// <summary>
        /// Gets the product by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Product GetProductById(int id)
        {
            using (var context = new MyApplicationContext())
            {
                return context.Products.Where(product => product.Id == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void UpdateProduct(Product product)
        {
            using (var context = new MyApplicationContext())
            {
                //left as an exercise
            }
        }
    }
}