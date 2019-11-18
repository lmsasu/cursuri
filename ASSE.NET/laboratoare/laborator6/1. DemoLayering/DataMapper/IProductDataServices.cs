using DemoEF6CodeFirst.DomainModel;
using System.Collections.Generic;

namespace DataMapper
{
    public interface IProductDataServices
    {
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        IList<Product> GetAllProducts();

        /// <summary>
        /// Gets the product by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Product GetProductById(int id);

        /// <summary>
        /// Adds the product.
        /// </summary>
        /// <param name="product">The product.</param>
        void AddProduct(Product product);

        /// <summary>
        /// Deletes the product.
        /// </summary>
        /// <param name="product">The product.</param>
        void DeleteProduct(Product product);

        /// <summary>
        /// Updates the product.
        /// </summary>
        /// <param name="product">The product.</param>
        void UpdateProduct(Product product);
    }
}