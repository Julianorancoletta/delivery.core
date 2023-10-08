using Delivery.Core.Messages;
using System;

namespace Delivery.Core.DomainObjects
{
    public class DomainException : Exception
    {
        public DomainException()
        {
            Console.WriteLine("");
        }

        public DomainException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message);
        }
    }
}