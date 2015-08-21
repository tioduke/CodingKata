package com.gildedrose.items;

public class ItemDecoratorFactory {
	
	static public ItemDecorator getInstance(Item itemToDecorate)
	{
		if (itemToDecorate.name.contains("Aged"))
		{
			return new AgedItem(itemToDecorate);
		}
		else if (itemToDecorate.name.contains("Sulfuras"))
		{
			return new LegendaryItem(itemToDecorate);
		}
		else if (itemToDecorate.name.contains("Backstage pass"))
		{
			return new BackstagePassItem(itemToDecorate);
		}
		else
		{
			return new RegularItem(itemToDecorate);
		}
	}

}
