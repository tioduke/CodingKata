package com.gildedrose.items;

public class BackstagePassItem extends ItemDecorator {
	
	// Constants
	private final int THRESHOLD_ONCE = 10;	
	private final int THRESHOLD_TWICE = 5;	
	private final int THRESHOLD_THRICE = 0;	

	// Constructors
	protected BackstagePassItem(Item itemToDecorate)
	{
		super(itemToDecorate);
	}

	// Protected methods
	@Override
	protected void updateQuality()
	{
		if (this.getSellIn() > THRESHOLD_ONCE)
		{
			this.increaseQualityOnce();
		}
		else if (this.getSellIn() > THRESHOLD_TWICE)
		{
			this.increaseQualityTwice();
		}
		else if (this.getSellIn() > THRESHOLD_THRICE)
		{
			this.increaseQualityThrice();
		}
		else  // this.isSellInEnded()
		{
			this.setQuality(this.MIN_QUALITY);
		}
	}

}
