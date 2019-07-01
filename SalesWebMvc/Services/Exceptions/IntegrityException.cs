using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(String message) : base(message)
        { 
        }
    }
}
