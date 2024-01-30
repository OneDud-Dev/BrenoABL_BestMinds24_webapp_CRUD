using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSPS.Domain.CustomExceptions.ProductCreationExceptions
{
    internal class Product_CodeCreationException : ADomainException
    {
        public Product_CodeCreationException(string message) : base(message)
        {
        }
    }
}
