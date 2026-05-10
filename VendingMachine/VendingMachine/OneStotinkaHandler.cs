using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class OneStotinkaHandler : CoinHandler
    {
        protected override bool TryHandle(Coin coin)
        {
            if (Math.Abs(coin.Diameter - 1.5) < 0.0001 &&
                Math.Abs(coin.Weight - 1) < 0.0001)
            {s
                Console.WriteLine("OneStotinkaHandler prie komandata i razpozna moneta ot 1 stotinka.");
                Console.WriteLine("Harakteristiki: " + coin);
                return true;
            }

            return false;
        }
    }
}
