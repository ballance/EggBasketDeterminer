using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ballance.EggBasketDeterminer
{
    public class EggBasket
    {
        public int Step { get; set; }

        public double EggCount { get; set; }

        public string Name { get; set; }

        public EggBasket(string name, double initialCount)
        {
            Name = name;
            EggCount = initialCount;
            Step = 0;
        }

        public void Add(double eggsToAdd)
        {
            EggCount += eggsToAdd;
        }

        public void Remove(double eggsToAdd)
        {
            EggCount -= eggsToAdd;
        }
    }
}
