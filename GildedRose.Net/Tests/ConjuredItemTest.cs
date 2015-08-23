using Xunit;

using GildedRose.Items;

namespace GildedRose.Tests
{
    public class ConjuredItemTest
    {
        
        [Fact] 
        public void updateQuality_SellinGreterThanZero_QualityDecreaseByTwo() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Conjured Mana Cake", SellIn=10, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Conjured Mana Cake", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(18, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinEqualsZero_QualityDecreaseByFour() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Conjured Mana Cake", SellIn=0, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Conjured Mana Cake", items[0].Name);
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(16, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinLessThanZero_QualityDecreaseByFour() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Conjured Mana Cake", SellIn=-1, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Conjured Mana Cake", items[0].Name);
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(16, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_QualityEqualsZero_QualityUnchanged() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Conjured Mana Cake", SellIn=10, Quality = 0} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Conjured Mana Cake", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_QualityEqualsFifty_QualityDecreaseByTwo() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Conjured Mana Cake", SellIn=10, Quality = 50} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Conjured Mana Cake", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(48, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_QualityEqualsThree_QualityToZero() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Conjured Mana Cake", SellIn=0, Quality = 3} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Conjured Mana Cake", items[0].Name);
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

    }
}
