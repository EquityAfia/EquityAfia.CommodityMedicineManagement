using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.ValueObjects
{
    public class Description
    {
        public string Value { get; }

        public Description(string value)
        {
            Value = value;
        }
    }
}

