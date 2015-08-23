using Xunit;

namespace GildedRose.Tests
{
	public class LegendaryItemTest
	{
		
		[Fact] 
		public void updateQuality_SellinGreterThanZero_QualityUnchanged() 
		{
			//Arrange
			Item[] items = new Item[] { new Item{Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20} };
			GildedRose app = new GildedRose(items);
			
			//Act
			app.UpdateQuality();
			
			//Assert
			Assert.Equal("Sulfuras, Hand of Ragnaros", items[0].Name);
			Assert.Equal(10, items[0].SellIn);
			Assert.Equal(20, items[0].Quality);
		}
		
		[Fact]
		public void updateQuality_SellinEqualsZero_QualityUnchanged() 
		{
			//Arrange
			Item[] items = new Item[] { new Item{Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 20} };
			GildedRose app = new GildedRose(items);
			
			//Act
			app.UpdateQuality();
			
			//Assert
			Assert.Equal("Sulfuras, Hand of Ragnaros", items[0].Name);
			Assert.Equal(0, items[0].SellIn);
			Assert.Equal(20, items[0].Quality);
		}
		
		[Fact]
		public void updateQuality_SellinLessThanZero_QualityUnchanged() 
		{
			//Arrange
			Item[] items = new Item[] { new Item{Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 20} };
			GildedRose app = new GildedRose(items);
			
			//Act
			app.UpdateQuality();
			
			//Assert
			Assert.Equal("Sulfuras, Hand of Ragnaros", items[0].Name);
			Assert.Equal(-1, items[0].SellIn);
			Assert.Equal(20, items[0].Quality);
		}
		
		[Fact]
		public void updateQuality_QualityEqualsZero_QualityUnchanged() 
		{
			//Arrange
			Item[] items = new Item[] { new Item{Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 0} };
			GildedRose app = new GildedRose(items);
			
			//Act
			app.UpdateQuality();
			
			//Assert
			Assert.Equal("Sulfuras, Hand of Ragnaros", items[0].Name);
			Assert.Equal(10, items[0].SellIn);
			Assert.Equal(0, items[0].Quality);
		}
		
		[Fact]
		public void updateQuality_QualityEqualsFifty_QualityUnchanged() 
		{
			//Arrange
			Item[] items = new Item[] { new Item{Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 50} };
			GildedRose app = new GildedRose(items);
			
			//Act
			app.UpdateQuality();
			
			//Assert
			Assert.Equal("Sulfuras, Hand of Ragnaros", items[0].Name);
			Assert.Equal(10, items[0].SellIn);
			Assert.Equal(50, items[0].Quality);
		}
		
		[Fact]
		public void updateQuality_QualityEqualsEighty_QualityUnchanged() 
		{
			//Arrange
			Item[] items = new Item[] { new Item{Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80} };
			GildedRose app = new GildedRose(items);
			
			//Act
			app.UpdateQuality();
			
			//Assert
			Assert.Equal("Sulfuras, Hand of Ragnaros", items[0].Name);
			Assert.Equal(10, items[0].SellIn);
			Assert.Equal(80, items[0].Quality);
		}

	}
}
