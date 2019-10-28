using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DemoValidationCustomer
{
    public class Customer
    {
        private string _name;

        //public String Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (value == null || value.Length < 3 || value.Length > 50)
        //        {
        //            throw new Exception("The name is null or too short or too long");
        //        }
        //        else 
        //        { 
        //            _name = value;
        //        }
        //    }
        //}

        [NotNullValidator(MessageTemplate = "The name cannot be null")]
        [StringLengthValidator(3, RangeBoundaryType.Inclusive, 50, RangeBoundaryType.Inclusive, MessageTemplate = "The name should have between {3} and {5} chars")]
        public String Name
        {
            get;
            set;
        }
    }
}
