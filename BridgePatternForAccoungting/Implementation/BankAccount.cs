namespace BridgePatternForAccoungting.Implementation
{
    public class BankAccount : IAccount
    {
        public decimal CalcTax(decimal salary)
        {
            return salary - 50;
        }
    }
}
