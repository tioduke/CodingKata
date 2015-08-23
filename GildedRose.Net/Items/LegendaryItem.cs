namespace GildedRose.Items
{
    public class LegendaryItem : ItemDecorator
    {
	
		// Constructors
		internal LegendaryItem(Item itemToDecorate) : base(itemToDecorate) { }
	
		// Protected methods
		protected override void UpdateSellIn() { }
	
		protected override void UpdateQuality() { }
	
	}
}