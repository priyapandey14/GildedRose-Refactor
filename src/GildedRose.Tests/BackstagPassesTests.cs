using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class BackstagPassesTests
    {
        [Test]
        public void Sellling15Quality20()
        {
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            };

            BackstagPasses handler = new BackstagPasses();
            handler.UpdateQuality(item);
            int expectedQuality = 21;
            int expectedSellin = 14;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling20Quality10()
        {
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 20,
                Quality = 10
            };

            BackstagPasses handler = new BackstagPasses();
            handler.UpdateQuality(item);
            int expectedQuality = 11;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling20Quality50()
        {
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 20,
                Quality = 50
            };

            BackstagPasses handler = new BackstagPasses();
            handler.UpdateQuality(item);
            int expectedQuality = 50;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling0Quality0()
        {
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 0
            };

            BackstagPasses handler = new BackstagPasses();
            handler.UpdateQuality(item);
            int expectedQuality = 0;
            int expectedSellin = -1;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }
    }
}
