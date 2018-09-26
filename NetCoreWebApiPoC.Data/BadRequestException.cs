using System;

namespace NetCoreWebApiPoC.Data
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {

        }
    }
}
