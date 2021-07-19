using System;
using System.Collections.Generic;
using System.Text;

namespace _36_Exceptions.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
