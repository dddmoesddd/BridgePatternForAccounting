using BridgePatternForAccoungting.Abstraction;
using BridgePatternForAccoungting.Implementation;
using System;

namespace BridgePatternForAccoungting
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction.AbstractionAccount bankAccount = new LegalPerson(new VipAccount());
            bankAccount.CalcTax(9000);
        }
    }
}
