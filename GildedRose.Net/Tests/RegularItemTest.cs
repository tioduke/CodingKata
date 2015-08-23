using Xunit;

using GildedRose.Items;

namespace GildedRose.Tests
{
    public class RegularItemTest
    {
        
        [Fact]
        public void updateQuality_SellinGreterThanZero_QualityDecreaseByOne()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("+5 Dexterity Vest", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(19, items[0].Quality);
        }
    
        [Fact] 
        public void updateQuality_SellinEqualsZero_QualityDecreaseByTwo() 
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("+5 Dexterity Vest", items[0].Name);
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(18, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinLessThanZero_QualityDecreaseByTwo() 
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "+5 Dexterity Vest", SellIn = -1, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("+5 Dexterity Vest", items[0].Name);
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(18, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_QualityEqualsZero_QualityUnchanged() 
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("+5 Dexterity Vest", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_QualityEqualsFifty_QualityDecreaseByOne() 
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "+5 Dexterity Vest", SellIn = 10, Quality = 50} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("+5 Dexterity Vest", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(49, items[0].Quality);
        }

    }
}
