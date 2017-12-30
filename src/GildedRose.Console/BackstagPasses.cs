using System;

namespace GildedRose.Console
{
    public class BackstagPasses : IItemHandler
    {
        public void UpdateQuality(Item item)
        {
            --item.SellIn;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }

            else if (item.SellIn <= 10)
            {
                item.Quality = item.Quality + 2;
            }

            else if (item.SellIn <=5 )
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.Quality < 50)
            {
                item.Quality = ++item.Quality;
            }
        }
    }
}
