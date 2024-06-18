/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        // Override Equals and GetHashCode for value object equality
        public override bool Equals(object obj)
        {
            if (obj is Money other)
            {
                return Amount == other.Amount && Currency == other.Currency;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, Currency);
        }
    }
}

*/
namespace ProductService.Domain.ValueObjects
{
    public class Price
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Price(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
