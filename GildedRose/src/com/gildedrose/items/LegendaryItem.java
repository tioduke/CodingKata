package com.gildedrose.items;

public class LegendaryItem extends ItemDecorator {
	
	// Constructors
	protected LegendaryItem(Item itemToDecorate)
	{
		super(itemToDecorate);
	}

	// Protected methods
	@Override
	protected void updateSellIn() { }

	@Override
	protected void updateQuality() { }

}
