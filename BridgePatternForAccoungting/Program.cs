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
            var tax = bankAccount.CalcTax(3432);
            Console.WriteLine("Caculated Tax  For Leagal Person Is {0} ", tax);
            Console.ReadLine();
        }
    }
}
