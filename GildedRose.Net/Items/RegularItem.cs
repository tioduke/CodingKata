namespace GildedRose.Items
{
    public class RegularItem : ItemDecorator
    {
	
		// Constructors
		internal RegularItem(Item itemToDecorate) : base(itemToDecorate) { }
	
		// Protected methods
		protected override void UpdateQuality()
		{
			if (this.IsSellInEnded())
			{
				this.DecreaseQualityTwice();
			}
			else
			{
				this.DecreaseQualityOnce();
			}
		}
		
	}
}