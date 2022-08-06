using System;
using System.Collections.Generic;
using System.Text;

namespace AviaProject.BLL.Infrastructure
{
    public class ValidationExeption : Exception
    {
        public string Property { get; protected set; }
        public ValidationExeption(string message, string prop) : base(message)
        {
            Property = prop;
        }
    }
}
