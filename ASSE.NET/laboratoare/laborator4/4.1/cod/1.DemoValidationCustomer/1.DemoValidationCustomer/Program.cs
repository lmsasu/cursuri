using Microsoft.Practices.EnterpriseLibrary.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DemoValidationCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = null;
            //customer.Name = "Aa";
            //in the naive implementation: Exception thrown
            ValidationResults validationResults = Validation.Validate<Customer>(customer);
            if (validationResults.Count == 0)
            {
                Console.WriteLine("The object is fine");
            }
            else
            {
                Console.WriteLine("There are some issues: ");
                foreach (ValidationResult vr in validationResults)
                {
                    Console.WriteLine(vr.Message);
                }
            }
        }
    }
}
