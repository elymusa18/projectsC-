using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class OneLevHandler : CoinHandler
    {
        protected override bool TryHandle(Coin coin)
        {
            if (Math.Abs(coin.Diameter - 2.4) < 0.0001 &&
                Math.Abs(coin.Weight - 10) < 0.0001)
            {
                Console.WriteLine("OneLevHandler prie komandata i razpozna moneta ot 1 lev.");
                Console.WriteLine("Harakteristiki: " + coin);
                return true;
            }

            return false;
        }
    }
}
