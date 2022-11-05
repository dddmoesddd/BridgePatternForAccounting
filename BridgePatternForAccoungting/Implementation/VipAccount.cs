using System;

namespace BridgePatternForAccoungting.Implementation
{
    public class VipAccount : IAccount
    {
        public decimal CalcTax(decimal salary)
        {
            return (salary * 10) / 100;
        }
    }
}
