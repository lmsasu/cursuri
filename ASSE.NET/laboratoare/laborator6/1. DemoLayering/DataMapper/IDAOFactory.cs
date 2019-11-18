using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMapper
{
    public interface IDAOFactory
    {
        ICustomerDataServices CustomerDataServices
        {
            get;
        }

        IProductDataServices ProducDataServices
        {
            get;
        }
    }
}
