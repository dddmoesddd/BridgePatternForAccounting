namespace BridgePatternForAccoungting.Implementation
{
    public class NormalAccount : IAccount
    {
        public decimal CalcTax(decimal salary)
        {
            return (salary * 60)/100;
        }
    }
}
