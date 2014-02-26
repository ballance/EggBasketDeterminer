using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ballance.EggBasketDeterminer
{
    public class AllBaskets
    {
        public List<EggBasket> BasketList = new List<EggBasket>();

        public void Add(List<EggBasket> basketsToAdd)
        {
            BasketList.AddRange(basketsToAdd);
        }

        public void GiveHalfPlusOneHalfTo(string senderName, string receiverName)
        {
            var sender = BasketList.First(b => b.Name.Equals(senderName, StringComparison.InvariantCultureIgnoreCase));
            var receiver = BasketList.First(b => b.Name.Equals(receiverName, StringComparison.InvariantCultureIgnoreCase));
            
           
            double eggsToMove = sender.EggCount / 2 + .5;

            Console.WriteLine("Giving {0} eggs from {1} to {2} [1/2 of {3} + 1/2 = {4}]", eggsToMove, sender.Name, receiverName, sender.EggCount, eggsToMove);
            
            sender.Remove(eggsToMove);
            receiver.Add(eggsToMove);
            sender.Step = sender.Step + 1;
            receiver.Step = receiver.Step + 1;

        }

        public void DisplayStatus()
        {
            foreach (var basket in BasketList)
            {
                if (basket.Name.Equals("David"))
                {
                    Console.WriteLine(String.Format("Step: {1,-12}", basket.Name, basket.Step));
                    Console.WriteLine("========");
                }
                Console.WriteLine(String.Format("{0,-12}: {1,-12}", basket.Name, basket.EggCount));
                   
            }
            Console.WriteLine();

        }

        public void Add(EggBasket eggBasket)
        {
            BasketList.Add(eggBasket);
        }
    }
}