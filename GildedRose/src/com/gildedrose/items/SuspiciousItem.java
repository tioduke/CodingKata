package com.gildedrose.items;

public class SuspiciousItem extends ItemDecorator {
	
	// Constructors
	protected SuspiciousItem(Item itemToDecorate)
	{
		super(itemToDecorate);
	}

	// Protected methods
	@Override
	protected void updateQuality()
	{
		if (this.isSellInOddNumber())
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
		else
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

}
