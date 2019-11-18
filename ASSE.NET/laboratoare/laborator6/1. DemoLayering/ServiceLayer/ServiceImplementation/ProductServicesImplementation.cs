using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEF6CodeFirst.DomainModel;
using DataMapper;

namespace ServiceLayer.ServiceImplementation
{
    public class ProductServicesImplementation : IProductServices
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetListOfProducts()
        {
            return DAOFactoryMethod.CurrentDAOFactory.ProducDataServices.GetAllProducts();
        }

        public void GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
