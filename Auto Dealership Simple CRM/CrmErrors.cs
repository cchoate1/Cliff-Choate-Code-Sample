using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResourceManagement
{
    class CrmErrors : Exception
    {
        public CrmErrors(string message)
           : base(message)
        {
        }
    }
}
