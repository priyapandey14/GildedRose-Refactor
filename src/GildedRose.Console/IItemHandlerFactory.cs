using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public interface IItemHandlerFactory
    {
        IItemHandler Create(string itemName);
    }
}
