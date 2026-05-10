using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Suzdavame obrabotchitsite
            var oneStHandler = new OneStotinkaHandler();
            var fiveStHandler = new FiveStotinkiHandler();
            var tenStHandler = new TenStotinkiHandler();
            var fiftyStHandler = new FiftyStotinkiHandler();
            var oneLevHandler = new OneLevHandler();

            // Svurzvame gi vuv verigata
            oneStHandler.SetNext(fiveStHandler)
                        .SetNext(tenStHandler)
                        .SetNext(fiftyStHandler)
                        .SetNext(oneLevHandler);

            // 2. Suzdavame 3 moneti 
            var coin1St = new Coin(1.5, 1);    // 1 st
            var coin50St = new Coin(2.1, 5);   // 50st
            var coin1Lv = new Coin(2.4, 10);   // 1 lev

            // 3. Podavame gi na priemnika (nachaloto na verigata)
            Console.WriteLine("=== Obrabotka na 1 st ===");
            oneStHandler.Handle(coin1St);

            Console.WriteLine("\n=== Obraabotka na 50 st ===");
            oneStHandler.Handle(coin50St);

            Console.WriteLine("\n=== Obrabotka na 1 lev ===");
            oneStHandler.Handle(coin1Lv);

            Console.ReadLine();
        }
    }
}