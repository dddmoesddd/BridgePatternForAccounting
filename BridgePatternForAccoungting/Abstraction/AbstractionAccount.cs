using BridgePatternForAccoungting.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternForAccoungting.Abstraction
{
    public  abstract class AbstractionAccount
    {
        protected IAccount _IAccount { get; set; }
        public abstract decimal CalcTax(decimal salary);
    }
}
