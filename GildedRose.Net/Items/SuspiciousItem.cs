namespace GildedRose.Net.Items
{
    public class SuspiciousItem : ItemDecorator
    {
    
        internal SuspiciousItem(Item itemToDecorate) : base(itemToDecorate) { }
        
        // Protected methods
        protected override void UpdateQuality()
        {
            if (this.SellInOddNumber)
            {
                if (this.SellInEnded)
                {
                    this.DecreaseQualityTwice();
                }
                else
                {
                    this.DecreaseQualityOnce();
                }        
            }
            else
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
}