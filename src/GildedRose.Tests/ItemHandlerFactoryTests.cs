using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class ItemHandlerFactoryTests
    {
        private IItemHandlerFactory itemFactory;

        [SetUp]
        public void Setup()
        {
            itemFactory = new ItemHandlerFactory();
        }

        [Test]
        public void GetAllHandlers()
        {
            IItemHandler ageBrioExpected = new AgedBrioHandler();
            var ageBrioActual = itemFactory.Create("Aged Brie");
            Assert.AreEqual(ageBrioExpected, ageBrioActual);

            IItemHandler backStagePassesExpected = new BackstagPasses();
            var backStageActual = itemFactory.Create("Backstage passes to a TAFKAL80ETC concert");
            Assert.AreEqual(backStagePassesExpected, backStageActual);

            IItemHandler dexterityExpected = new StandardItemHandler();
            var dexterityActual = itemFactory.Create(" + 5 Dexterity Vest");
            Assert.AreEqual(dexterityExpected, dexterityActual);

            IItemHandler elixirMongooseExpected = new StandardItemHandler();
            var elixirMongooseActual = itemFactory.Create("Elixir of the Mongoose");
            Assert.AreEqual(elixirMongooseExpected, elixirMongooseActual);

            IItemHandler sulfurasExpected = new StandardItemHandler();
            var sulfurasActual = itemFactory.Create("Sulfuras, Hand of Ragnaros");
            Assert.AreEqual(sulfurasExpected, sulfurasActual);

            IItemHandler conjuredManaExpected = new StandardItemHandler();
            var conjuredManaActual = itemFactory.Create("Conjured Mana Cake");
            Assert.AreEqual(conjuredManaExpected, conjuredManaActual);            
        }

        [TearDown]
        public void TearDown()
        {
            itemFactory = null;
        }
    }
}
