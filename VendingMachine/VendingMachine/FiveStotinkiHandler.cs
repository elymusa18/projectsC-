using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class FiveStotinkiHandler : CoinHandler
    {
        protected override bool TryHandle(Coin coin)
        {
            if (Math.Abs(coin.Diameter - 2.0) < 0.0001 &&
                Math.Abs(coin.Weight - 3) < 0.0001)
            {
                Console.WriteLine("FiveStotinkiHandler prie komandata i razpozna moneta ot 5 stotinki.");
                Console.WriteLine("Harakteristiki: " + coin);
                return true;
            }

            return false;
        }
    }
}

