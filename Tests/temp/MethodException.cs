using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class MethodException:ApplicationException
    {
        public MethodException() { }
        public MethodException(string message) : base(message) { }
    }
}
