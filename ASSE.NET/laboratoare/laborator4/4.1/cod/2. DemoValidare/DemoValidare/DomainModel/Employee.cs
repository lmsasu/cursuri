using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace DemoValidare.DomainModel
{
    public class Employee
    {
        [NotNullValidator(MessageTemplate="The name cannot be null")]
        [StringLengthValidator(2, RangeBoundaryType.Inclusive, 40, RangeBoundaryType.Inclusive, ErrorMessage="The name should have between {3} and {5} letters")]
        public string Name
        {
            get;
            set;
        }

        [NotNullValidator(MessageTemplate="Missing code")]
        [RegexValidator(@"^\d{13}$", MessageTemplate = "The code should have exactly 13 digits")]
        public String PersonalNumericCode
        {
            get;
            set;
        }

        //[NotNullValidator]??
        [RangeValidator(18, RangeBoundaryType.Inclusive, 15, RangeBoundaryType.Ignore, MessageTemplate="Minimum age: {3}")]
        public int AgeAtHiring
        {
            get;
            set;
        }

        [ValidatorComposition(Microsoft.Practices.EnterpriseLibrary.Validation.CompositionType.Or)]
        [StringLengthValidator(3, 4)]
        [StringLengthValidator(6, 10)]
        public String OtherProperty
        {
            get;
            set;
        }

        [DomainValidator("m", "f", "M", "F", MessageTemplate = "Unknown gender")]
        [NotNullValidator]
        public String Gender
        {
            get;
            set;
        }
    }
}
