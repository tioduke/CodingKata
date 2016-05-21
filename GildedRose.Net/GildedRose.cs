using System.Collections.Generic;

using GildedRose.Net.Items;

namespace GildedRose.Net
{
    class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items) 
        {
            this.Items = Items;
        }
        
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                ItemDecorator decoratedItem = ItemDecoratorFactory.CreateInstance(Items[i]);
                decoratedItem.Update();
            }
        }
        
    }
    
}
