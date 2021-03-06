﻿using System;
using System.Collections.Generic;

namespace GildedRose.Console
{
    public class ItemHandlerFactory : IItemHandlerFactory
    {
        private const string agedBrio = "Aged Brie";

        private const string backStage = "Backstage passes to a TAFKAL80ETC concert";

        private const string sulfuras = "Sulfuras, Hand of Ragnaros";

        private HashSet<string> itemList = new HashSet<string>
        {
            "+5 Dexterity Vest",
            "Elixir of the Mongoose"                 
        };

        private const string conjure = "Conjured Mana Cake";

        public IItemHandler Create(string itemName)
        {
            if (string.Equals(itemName, agedBrio, StringComparison.OrdinalIgnoreCase))
            {
                return new AgedBrioHandler();
            }
            else if (string.Equals(itemName, backStage, StringComparison.OrdinalIgnoreCase))
            {
                return new BackstagPasses();
            }
            else if (itemList.Contains(itemName))
            {
                return new StandardItemHandler(1);
            }
            else if (string.Equals(itemName, sulfuras, StringComparison.OrdinalIgnoreCase))
            {
                return new NoChangeHandler();
            }
            else if (string.Equals(itemName, conjure, StringComparison.OrdinalIgnoreCase))
            {
                return new StandardItemHandler(2);
            }

            throw new InvalidOperationException($"{itemName} is not supported");
        }
    }
}
