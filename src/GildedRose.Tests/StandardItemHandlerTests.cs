using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class StandardItemHandlerTests
    {
        [Test]
        public void Selling10Quality20DexterityVest()
        {
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 19;
            int expectedSellin = 9;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Selling20Quality10DexterityVest()
        {
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 20, Quality = 10 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 9;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Selling20Quality50DexterityVest()
        {
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 20, Quality = 50 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 49;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Selling0Quality0DexterityVest()
        {
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 0;
            int expectedSellin = -1;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling5Quality7Elixir()
        {
            Item item = new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 6;
            int expectedSellin = 4;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling20Quality50Elixir()
        {
            Item item = new Item { Name = "Elixir of the Mongoose", SellIn = 20, Quality = 50 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 49;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling20Quality10Elixir()
        {
            Item item = new Item { Name = "Elixir of the Mongoose", SellIn = 20, Quality = 10 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 9;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling0Quality0Elixir()
        {
            Item item = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 0 };

            StandardItemHandler handler = new StandardItemHandler(1);
            handler.UpdateQuality(item);
            int expectedQuality = 0;
            int expectedSellin = -1;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling3Quality6Conjure()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };

            StandardItemHandler handler = new StandardItemHandler(2);
            handler.UpdateQuality(item);
            int expectedQuality = 4;
            int expectedSellin = 2;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling20Quality10Conjure()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 20, Quality = 10 };

            StandardItemHandler handler = new StandardItemHandler(2);
            handler.UpdateQuality(item);
            int expectedQuality = 8;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling20Quality50Conjure()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 20, Quality = 50 };

            StandardItemHandler handler = new StandardItemHandler(2);
            handler.UpdateQuality(item);
            int expectedQuality = 48;
            int expectedSellin = 19;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }

        [Test]
        public void Sellling0Quality0Conjure()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 0 };

            StandardItemHandler handler = new StandardItemHandler(2);
            handler.UpdateQuality(item);
            int expectedQuality = 0;
            int expectedSellin = -1;
            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.AreEqual(expectedSellin, item.SellIn);
        }
    }
}
