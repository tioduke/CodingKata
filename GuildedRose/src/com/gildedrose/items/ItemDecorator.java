package com.gildedrose.items;

public abstract class ItemDecorator {

	// Constants
	protected final int MIN_QUALITY = 0;
	protected final int MAX_QUALITY = 50;
	
	// Members
	private Item itemToDecorate;
	
	// Constructors
	protected ItemDecorator(Item itemToDecorate)
	{
		this.itemToDecorate = itemToDecorate;
	}
	
	// Properties
	public String getName()
	{
		return this.itemToDecorate.name;
	}
	
	public void setName(String name)
	{
		this.itemToDecorate.name = name;
	}
	
	public int getSellIn()
	{
		return this.itemToDecorate.sellIn;
	}
	
	public void setSellIn(int sellIn)
	{
		this.itemToDecorate.sellIn = sellIn;
	}
	
	public int getQuality()
	{
		return this.itemToDecorate.quality;
	}
	
	public void setQuality(int quality)
	{
		this.itemToDecorate.quality = quality;
	}

	// Read-only properties
    protected boolean IsSellInEnded()
    {
        return this.itemToDecorate.sellIn <= 0;
    }

    protected boolean IsSellInEvenNumber()
    {
        return this.itemToDecorate.sellIn % 2 == 0;
    }

    protected boolean IsSellInOddNumber()
    {
        return !this.IsSellInEvenNumber();
    }
	
    // Public methods
	public void update()
	{
		this.updateQuality();
		this.updateSellIn();
	}
	
	// Protected methods
	protected abstract void updateQuality();
	
	protected void updateSellIn()
	{
		this.itemToDecorate.sellIn--;
	}

	protected void decreaseQualityOnce()
	{
		this.itemToDecorate.quality -= 1;
		if (this.itemToDecorate.quality < MIN_QUALITY) this.itemToDecorate.quality = MIN_QUALITY;
	}
	
	protected void decreaseQualityTwice()
	{
		this.itemToDecorate.quality -= 2;
		if (this.itemToDecorate.quality < MIN_QUALITY) this.itemToDecorate.quality = MIN_QUALITY;
	}
	
	protected void decreaseQualityQuarce()
	{
		this.itemToDecorate.quality -= 4;
		if (this.itemToDecorate.quality < MIN_QUALITY) this.itemToDecorate.quality = MIN_QUALITY;
	}
	
	protected void increaseQualityOnce()
	{
		this.itemToDecorate.quality += 1;
		if (this.itemToDecorate.quality > MAX_QUALITY) this.itemToDecorate.quality = MAX_QUALITY;
	}
	
	protected void increaseQualityTwice()
	{
		this.itemToDecorate.quality += 2;
		if (this.itemToDecorate.quality > MAX_QUALITY) this.itemToDecorate.quality = MAX_QUALITY;
	}
	
	protected void increaseQualityThrice()
	{
		this.itemToDecorate.quality += 3;
		if (this.itemToDecorate.quality > MAX_QUALITY) this.itemToDecorate.quality = MAX_QUALITY;
	}

}
