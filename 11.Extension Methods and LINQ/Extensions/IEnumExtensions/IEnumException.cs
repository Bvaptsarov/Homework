using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.IEnumExtensions
{
    public class IEnumException : SystemException
    {     
            public IEnumException() { }
            public IEnumException(string message) : base(message) { }
            public IEnumException(string message, Exception innerException) : base(message, innerException) { }     
    }
}
