using System.Collections.Generic;

using GildedRose.Items;

namespace GildedRose
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
				ItemDecorator decoratedItem = ItemDecoratorFactory.getInstance(Items[i]);
				decoratedItem.Update();
			}
		}
		
	}
	
}
