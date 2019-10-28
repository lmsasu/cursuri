using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;


namespace DemoValidare.DomainModel
{
    public class Money
    {
        [RangeValidator(typeof(decimal), "0", RangeBoundaryType.Exclusive, "100", RangeBoundaryType.Ignore, MessageTemplate="The price must be between {3} ({4}) and {5} ({6})")]
        public decimal Amount
        {
            get;
            set;
        }

        [NotNullValidator]
        [DomainValidator("RON", "USD", "EUR", MessageTemplate="The currency {0} is not allowed")]
        public String Currency
        {
            get;
            set;
        }

        public static bool operator <(Money x, Money y)
        {
            if (x.Currency != y.Currency)
            {
                throw new Exception("nu se pot compara doua sume in valute diferite");
            }
            return x.Amount < y.Amount;
        }

        public static bool operator >(Money x, Money y)
        {
            if (x.Currency != y.Currency)
            {
                throw new Exception("nu se pot compara doua sume in valute diferite");
            }
            return x.Amount > y.Amount;
        }

        public override string ToString()
        {
            return Amount.ToString() + " " + Currency.ToString();
        }
    }
}
