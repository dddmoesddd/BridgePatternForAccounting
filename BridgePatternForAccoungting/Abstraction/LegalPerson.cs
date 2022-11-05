using BridgePatternForAccoungting.Implementation;

namespace BridgePatternForAccoungting.Abstraction
{
    public class LegalPerson : AbstractionAccount
    {

        public LegalPerson(IAccount iaccount)
        {
            this._IAccount = iaccount;
        }
        public override decimal CalcTax(decimal salary)
        {
         return   this._IAccount.CalcTax(salary);
        }
    }
}
