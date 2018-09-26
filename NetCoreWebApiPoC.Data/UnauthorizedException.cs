using System;

namespace NetCoreWebApiPoC.Data
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string message) : base(message)
        {

        }
    }
}
