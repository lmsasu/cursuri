using DemoEF.DomainModel;
using DemoEF.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //listAllEmployees();

            //addEmployee();

            //modifyEmployee();

            deleteEmployee();
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        private static void deleteEmployee()
        {
            using (var context = new Northwind())
            {
                var thatEmployee = context.Employees.Where(emp => emp.FirstName == "Wilhelm" && emp.LastName == "Ionescu").FirstOrDefault();
                if (thatEmployee != null)
                {
                    context.Employees.Remove(thatEmployee);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("No guy named W.I.");
                }
            }
        }

        /// <summary>
        /// Modifies the employee.
        /// </summary>
        private static void modifyEmployee()
        {
            using (var context = new Northwind())
            {
                var thatEmployee = context.Employees.Where(emp => emp.FirstName == "Wilhelm" && emp.LastName == "Popescu").FirstOrDefault();
                if (thatEmployee != null)
                {
                    thatEmployee.LastName = "Ionescu";
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("No guy named W.P.");
                }
            }
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        private static void addEmployee()
        {
            using (var context = new Northwind())
            {
                var employee = new Employee
                {
                    FirstName = "Wilhelm",
                    LastName = "Popescu",
                };
                context.Employees.Add(employee);
                context.SaveChanges();
                Console.WriteLine($"PK of newly added record: {employee.EmployeeID}");
            }
        }

        /// <summary>
        /// Lists all employees.
        /// </summary>
        private static void listAllEmployees()
        {
            using (var context = new Northwind())
            {
                var allCustomers = from employee in context.Employees
                                   orderby employee.FirstName
                                   select employee;

                foreach (var item in allCustomers)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}");
                }
            }
        }
    }
}
