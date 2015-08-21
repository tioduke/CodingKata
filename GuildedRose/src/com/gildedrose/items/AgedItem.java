package com.gildedrose.items;

public class AgedItem extends ItemDecorator {
	
	// Constructors
	protected AgedItem(Item itemToDecorate)
	{
		super(itemToDecorate);
	}

	// Protected methods
	@Override
	protected void updateQuality()
	{
		if (super.IsSellInEnded())
		{
			super.increaseQualityTwice();
		}
		else
		{
			super.decreaseQualityOnce();
		}
	}

}
