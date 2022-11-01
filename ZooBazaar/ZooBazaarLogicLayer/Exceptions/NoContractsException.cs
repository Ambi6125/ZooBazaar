using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.Exceptions
{
    public class NoContractsException : Exception
    {
        public override string Message => "Employee has no Contracts";
    }
}
