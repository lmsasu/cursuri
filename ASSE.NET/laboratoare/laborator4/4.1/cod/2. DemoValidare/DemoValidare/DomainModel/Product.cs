using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace DemoValidare.DomainModel
{
    [HasSelfValidation]
    public class Product
    {
        [ObjectValidator]
        [NotNullValidator(MessageTemplate = "The buy price cannot be null")]
        public Money BuyPrice
        {
            get;
            set;
        }

        [ObjectValidator]
        [NotNullValidator(MessageTemplate = "The sell price cannot be null")]
        public Money SellPrice
        {
            get;
            set;
        }

        [SelfValidation]
        public void ValidatePrice(ValidationResults validationResults)
        {
            if (BuyPrice.Currency != SellPrice.Currency)
            {
                validationResults.AddResult(new ValidationResult("The same currency is required", this, "ValidatePrice", "error", null));
            }
            if (BuyPrice > SellPrice)
            {
                validationResults.AddResult(new ValidationResult("You sell to cheap", this, "ValidatePrice", "error", null));
            }
        }
    }
}
