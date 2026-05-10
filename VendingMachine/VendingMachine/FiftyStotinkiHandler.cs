using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class FiftyStotinkiHandler : CoinHandler
    {
        protected override bool TryHandle(Coin coin)
        {
            if (Math.Abs(coin.Diameter - 2.1) < 0.0001 &&
                Math.Abs(coin.Weight - 5) < 0.0001)
            {
                Console.WriteLine("FiftyStotinkiHandler prie komandata i razpozna moneta ot 50 stotinki.");
                Console.WriteLine("Harakteristiki: " + coin);
                return true;
            }

            return false;
        }
    }
}

