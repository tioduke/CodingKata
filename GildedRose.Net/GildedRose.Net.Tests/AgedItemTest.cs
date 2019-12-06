using Xunit;
using Xunit.Categories;

using GildedRose.Net.Items;

namespace GildedRose.Net.Tests
{
    public class AgedItemTest
    {
        [Fact, UnitTest]
        public void UpdateQuality_SellinGreterThanZero_QualityIncreaseByOne()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Aged Brie", SellIn = 10, Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Aged Brie", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(21, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsZero_QualityIncreaseByTwo()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Aged Brie", SellIn = 0, Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Aged Brie", items[0].Name);
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(22, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_SellinLessThanZero_QualityIncreaseByTwo()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Aged Brie", SellIn = -1, Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Aged Brie", items[0].Name);
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(22, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_QualityEqualsZero_QualityIncreaseByOne()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Aged Brie", SellIn = 10, Quality = 0} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Aged Brie", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_QualityEqualsFifty_QualityUnchanged()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Aged Brie", SellIn = 10, Quality = 50} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Aged Brie", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(50, items[0].Quality);
        }
    }
}
