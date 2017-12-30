using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class AgedBrioHandler : IItemHandler
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn = item.SellIn - 1;
            if (item.SellIn < 0 && item.Quality < 50)
            {
                ++item.Quality;
            }

            if (item.Quality < 50)
            {
                ++item.Quality;
            }
        }
    }
}
