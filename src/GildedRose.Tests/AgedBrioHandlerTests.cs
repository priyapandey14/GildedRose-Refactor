using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class AgedBrioHandlerTests
    {
        public void Setup()
        {

        }

       [Test]
       public void Sellling2Quality0()
       {
            Item item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
            AgedBrioHandler handler = new AgedBrioHandler();
            handler.UpdateQuality(item);
            int expectedQuality = 1;
            int expectedSellin = 1;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
       }

        [Test]
        public void Sellling20Quality10()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 20, Quality = 10 };
            AgedBrioHandler handler = new AgedBrioHandler();
            handler.UpdateQuality(item);
            int expectedQuality = 11;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling20Quality50()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 20, Quality = 50 };
            AgedBrioHandler handler = new AgedBrioHandler();
            handler.UpdateQuality(item);
            int expectedQuality = 50;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling0Quality0()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 };
            AgedBrioHandler handler = new AgedBrioHandler();
            handler.UpdateQuality(item);
            int expectedQuality = 2;
            int expectedSellin = -1;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }
    }
}
