namespace GildedRose.Items
{
    public class SuspiciousItem : ItemDecorator
    {
    
        internal SuspiciousItem(Item itemToDecorate) : base(itemToDecorate) { }
        
        // Protected methods
        protected override void UpdateQuality()
        {
            if (this.IsSellInOddNumber())
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
            else
            {
                if (this.IsSellInEnded())
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