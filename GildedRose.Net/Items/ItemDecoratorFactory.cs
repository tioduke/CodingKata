namespace GildedRose.Items
{
    public class ItemDecoratorFactory
    {
        static public ItemDecorator getInstance(Item itemToDecorate)
        {
            if (itemToDecorate.Name.Contains("Aged"))
            {
                return new AgedItem(itemToDecorate);
            }
            else if (itemToDecorate.Name.Contains("Sulfuras"))
            {
                return new LegendaryItem(itemToDecorate);
            }
            else if (itemToDecorate.Name.Contains("Backstage pass"))
            {
                return new BackstagePassItem(itemToDecorate);
            }
            else
            {
                return new RegularItem(itemToDecorate);
            }
        }
        
    }
}