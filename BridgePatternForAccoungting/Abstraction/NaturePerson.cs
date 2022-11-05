using BridgePatternForAccoungting.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternForAccoungting.Abstraction
{
    public class NaturePerson : AbstractionAccount
    {
        public NaturePerson(IAccount account)
        {
            this._IAccount = account;
        }

        public override decimal CalcTax(decimal salary)
        {
            return this.CalcTax(salary);
        }
    }
}
