using Xunit;

using GildedRose.Items;

namespace GildedRose.Tests
{
    public class SuspicicousItemTest
    {
        
        [Fact]
        public void updateQuality_SellinEvenAndGreterThanZero_QualityDecreaseByTwo() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=10, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(18, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinOddAndGreterThanZero_QualityDecreaseByOne() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=9, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(8, items[0].SellIn);
            Assert.Equal(19, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinEqualsZero_QualityDecreaseByFour() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=0, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(16, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinEvenAndLessThanZero_QualityDecreaseByFour() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=-2, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(-3, items[0].SellIn);
            Assert.Equal(16, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinOddAndLessThanZero_QualityDecreaseByTwo() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=-1, Quality = 20} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(18, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinEvenAndQualityEqualsZero_QualityUnchanged() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=10, Quality = 0} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinOddAndQualityEqualsZero_QualityUnchanged() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=9, Quality = 0} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(8, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinEvenAndQualityEqualsFifty_QualityDecreaseByTwo() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=10, Quality = 50} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(48, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinOddAndQualityEqualsFifty_QualityDecreaseByOne() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=9, Quality = 50} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(8, items[0].SellIn);
            Assert.Equal(49, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinEqualsZeroAndQualityEqualsThree_QualityToZero() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=0, Quality = 3} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }
    
        [Fact]
        public void updateQuality_SellinEqualsNegativeOneAndQualityEqualsOne_QualityToZero() {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Suspicious Wooden shield", SellIn=-1, Quality = 1} };
            GildedRose app = new GildedRose(items);
            
            //Act
            app.UpdateQuality();
            
            //Assert
            Assert.Equal("Suspicious Wooden shield", items[0].Name);
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

    }
}
