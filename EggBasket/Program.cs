using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballance.EggBasketDeterminer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int eggCountAttempt = 31;

            while (true)
            {

                var baskets = new AllBaskets();

                Console.WriteLine("===============");
                Console.WriteLine("Starting David having {0} eggs in his basket...", eggCountAttempt);
               
                baskets.Add(new EggBasket("David", eggCountAttempt));
                baskets.Add(new EggBasket("Chris", 0));
                baskets.Add(new EggBasket("JonathanB", 0));
                baskets.Add(new EggBasket("Bob", 0));
                baskets.Add(new EggBasket("jonathanF", 0));


                baskets.DisplayStatus();
                baskets.GiveHalfPlusOneHalfTo("David", "Chris");

                baskets.DisplayStatus();
                baskets.GiveHalfPlusOneHalfTo("David", "JonathanB");

                baskets.DisplayStatus();
                baskets.GiveHalfPlusOneHalfTo("David", "Bob");

                baskets.DisplayStatus();
                baskets.GiveHalfPlusOneHalfTo("David", "JonathanF");

                 baskets.DisplayStatus();

                Console.ReadKey();
                if (baskets.BasketList.First(x => x.Name == "David").EggCount % 1 == 0)
                {
                    Console.WriteLine("****                                  **** Got an even number with {0} !!!", eggCountAttempt);
                }
                eggCountAttempt++;
            }

            Console.ReadKey();
        }
    }
}
