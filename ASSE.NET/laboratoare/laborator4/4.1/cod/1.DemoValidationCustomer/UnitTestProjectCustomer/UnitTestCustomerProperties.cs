using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.DemoValidationCustomer;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace UnitTestProjectCustomer
{
    [TestClass]
    public class UnitTestCustomerProperties
    {
        private Customer customer;

        [TestInitialize]
        public void InitCustomer()
        {
            customer = new Customer();
        }

        [TestMethod]
        public void TestMethodCorrectName()
        {
            customer.Name = "John";
            ValidationResults validationResults = Validation.Validate<Customer>(customer);
            Assert.AreEqual(0, validationResults.Count);
        }

        [TestMethod]
        public void TestMethodLongEnoughName()
        {
            customer.Name = "Dan";
            ValidationResults validationResults = Validation.Validate<Customer>(customer);
            Assert.AreEqual(0, validationResults.Count);
        }

        [TestMethod]
        public void TestMethodNameNotTooLong()
        {
            customer.Name = new String('a', 50);
            ValidationResults validationResults = Validation.Validate<Customer>(customer);
            Assert.AreEqual(validationResults.Count, 0);
        }

        [TestMethod]
        public void TestMethodNameTooShort()
        {
            customer.Name = new String('a', 2);
            ValidationResults validationResults = Validation.Validate<Customer>(customer);
            Assert.AreNotEqual(0, validationResults.Count);
        }

        [TestMethod]
        public void TestMethodNameTooLong()
        {
            customer.Name = new String('a', 51);
            ValidationResults validationResults = Validation.Validate<Customer>(customer);
            Assert.AreNotEqual(0, validationResults.Count);
        }

        [TestMethod]
        public void TestNullName()
        {
            customer.Name = null;
            ValidationResults validationResults = Validation.Validate<Customer>(customer);
            Assert.AreNotEqual(0, validationResults.Count);
        }
    }
}
