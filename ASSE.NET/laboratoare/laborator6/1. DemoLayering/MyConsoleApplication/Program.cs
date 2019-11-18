using ServiceLayer;
using ServiceLayer.ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            listAllProducts();
        }

        private static void listAllProducts()
        {
            IProductServices service = new ProductServicesImplementation();

            foreach (var item in service.GetListOfProducts())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
