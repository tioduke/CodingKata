namespace GildedRose.Items
{
    public class AgedItem : ItemDecorator
    {
    
        internal AgedItem(Item itemToDecorate) : base(itemToDecorate) { }
		
        // Protected methods
        protected override void UpdateQuality()
        {
            if (this.IsSellInEnded())
            {
                this.IncreaseQualityTwice();
            }
            else
            {
                this.IncreaseQualityOnce();
            }
        }
        
	}
}