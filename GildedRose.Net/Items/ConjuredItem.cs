namespace GildedRose.Items
{
    public class ConjuredItem : ItemDecorator
    {
    
        internal ConjuredItem(Item itemToDecorate) : base(itemToDecorate) { }
        
        // Protected methods
        protected override void UpdateQuality()
        {
            if (this.SellInEnded)
            {
                this.DecreaseQualityQuarce();
            }
            else
            {
                this.DecreaseQualityTwice();
            }
        }
        
    }
}