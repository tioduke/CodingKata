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
		if (this.isSellInEnded())
		{
			this.increaseQualityTwice();
		}
		else
		{
			this.increaseQualityOnce();
		}
	}

}
