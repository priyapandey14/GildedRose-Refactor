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
            var ageBrioActual = itemFactory.Create("Aged Brie");
            Assert.IsTrue(typeof(AgedBrioHandler) == ageBrioActual.GetType());
            
            var backStageActual = itemFactory.Create("Backstage passes to a TAFKAL80ETC concert");
            Assert.IsTrue(typeof(BackstagPasses) == backStageActual.GetType());
            
            var dexterityActual = itemFactory.Create("+5 Dexterity Vest");
            Assert.IsTrue(typeof(StandardItemHandler) == dexterityActual.GetType());
                        
            var elixirMongooseActual = itemFactory.Create("Elixir of the Mongoose");
            Assert.IsTrue(typeof(StandardItemHandler) == elixirMongooseActual.GetType());
                        
            var sulfurasActual = itemFactory.Create("Sulfuras, Hand of Ragnaros");
            Assert.IsTrue(typeof(NoChangeHandler) == sulfurasActual.GetType());
            
            var conjuredManaActual = itemFactory.Create("Conjured Mana Cake");
            Assert.AreEqual(typeof(StandardItemHandler), conjuredManaActual.GetType());            
        }

        [TearDown]
        public void TearDown()
        {
            itemFactory = null;
        }
    }
}
