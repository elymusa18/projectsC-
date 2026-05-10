using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class TenStotinkiHandler : CoinHandler
    {
        protected override bool TryHandle(Coin coin)
        {
            if (Math.Abs(coin.Diameter - 1.3) < 0.0001 &&
                Math.Abs(coin.Weight - 2) < 0.0001)
            {
                Console.WriteLine("TenStotinkiHandler prie komandata i razpozna moneta ot 10 stotinki.");
                Console.WriteLine("Harakteristiki: " + coin);
                return true;
            }

            return false;
        }
    }
}
