package com.gildedrose.items;

public class RegularItem extends ItemDecorator {
	
	// Constructors
	protected RegularItem(Item itemToDecorate)
	{
		super(itemToDecorate);
	}

	// Protected methods
	@Override
	protected void updateQuality()
	{
		if (this.isSellInEnded())
		{
			this.decreaseQualityTwice();
		}
		else
		{
			this.decreaseQualityOnce();
		}
	}
	
}
