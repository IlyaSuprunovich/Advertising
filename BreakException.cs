using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertising
{
    public class BreakException : Exception
    {
        public new string Message;

        public BreakException()
        {
            Message = "Долбаеб";
        }
    }
}
