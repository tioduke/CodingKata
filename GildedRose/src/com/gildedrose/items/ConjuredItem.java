package com.gildedrose.items;

public class ConjuredItem extends ItemDecorator {
	
	// Constructors
	protected ConjuredItem(Item itemToDecorate)
	{
		super(itemToDecorate);
	}

	// Protected methods
	@Override
	protected void updateQuality()
	{
		if (this.isSellInEnded())
		{
			this.decreaseQualityQuarce();
		}
		else
		{
			this.decreaseQualityTwice();
		}
	}

}
