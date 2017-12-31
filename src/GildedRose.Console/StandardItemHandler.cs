namespace GildedRose.Console
{
    public class StandardItemHandler : IItemHandler
    {
        private int degradeQuality;

        public StandardItemHandler(int degradeQuality)
        {
            this.degradeQuality = degradeQuality;
        }

        public void UpdateQuality(Item item)
        {
            --item.SellIn;
            if (item.Quality > 0)
            {
                if (item.SellIn < 0)
                {
                    item.SellIn = 2;
                }
                else
                {
                    item.SellIn = 1;
                }

                item.Quality -= degradeQuality * item.SellIn;
            }
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
