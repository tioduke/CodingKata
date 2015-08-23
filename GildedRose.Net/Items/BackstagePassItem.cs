namespace GildedRose.Items
{
    public class BackstagePassItem : ItemDecorator
    {
		
		// Constants
		private const int THRESHOLD_ONCE = 10;	
		private const int THRESHOLD_TWICE = 5;	
		private const int THRESHOLD_THRICE = 0;	

		// Constructors
		internal BackstagePassItem(Item itemToDecorate) : base(itemToDecorate) { }
	
		// Protected methods
		protected override void UpdateQuality()
		{
			if (this.SellIn > THRESHOLD_ONCE)
			{
				this.IncreaseQualityOnce();
			}
			else if (this.SellIn > THRESHOLD_TWICE)
			{
				this.IncreaseQualityTwice();
			}
			else if (this.SellIn > THRESHOLD_THRICE)
			{
				this.IncreaseQualityThrice();
			}
			else  // this.IsSellInEnded()
			{
				this.Quality = MIN_QUALITY;
			}
		}
		
	}
}