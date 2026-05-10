using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class CoinHandler
    {
        protected CoinHandler _next;

        public CoinHandler SetNext(CoinHandler next)
        {
            _next = next;
            return next;
        }

        public void Handle(Coin coin)
        {
            if (!TryHandle(coin) && _next != null)
            {
                _next.Handle(coin);
            }
            else if (_next == null && !TryHandle(coin))
            {
                Console.WriteLine("Monetata ne mozhe da bude razpoznata.");
            }
        }

        
        protected abstract bool TryHandle(Coin coin);
    }
}

