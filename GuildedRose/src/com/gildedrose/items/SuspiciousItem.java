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
		if (this.IsSellInOddNumber())
		{
			if (this.IsSellInEnded())
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
			if (this.IsSellInEnded())
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
