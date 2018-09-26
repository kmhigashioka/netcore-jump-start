using System;

namespace NetCoreWebApiPoC.Data
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
