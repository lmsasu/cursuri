using DemoEF6CodeFirst.DomainModel;
using System.Collections.Generic;

namespace DataMapper
{
    public interface ICustomerDataServices
    {
        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
        IList<Customer> GetAllCustomers();

        /// <summary>
        /// Adds the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void AddCustomer(Customer customer);

        /// <summary>
        /// Deletes the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void DeleteCustomer(Customer customer);

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void UpdateCustomer(Customer customer);
    }
}