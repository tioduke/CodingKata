using Xunit;
using Xunit.Categories;

using GildedRose.Net.Items;

namespace GildedRose.Net.Tests.Items
{
    public class BackstagePassItemTest
    {
        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsEleven_QualityIncreaseByOne()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(10, items[0].SellIn);
            Assert.Equal(21, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsTen_QualityIncreaseByTwo()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(22, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_SellinBetweenSixAndTen_QualityIncreaseByTwo()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6,Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(5, items[0].SellIn);
            Assert.Equal(22, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsFive_QualityIncreaseByThree()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(4, items[0].SellIn);
            Assert.Equal(23, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_SellinBetweenOneAndFive_QualityIncreaseByThree()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(23, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsZero_QualityToZero()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_QualityEqualsZero_QualityIncreaseByOne()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 0} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(10, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_QualityEqualsFifty_QualityUnchanged()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 50} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(10, items[0].SellIn);
            Assert.Equal(50, items[0].Quality);
        }

        [Fact, UnitTest]
        public void UpdateQuality_QualityEqualsFortyNine_QualityToFifty()
        {
            //Arrange
            Item[] items = new Item[] { new Item{Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49} };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.Equal(4, items[0].SellIn);
            Assert.Equal(50, items[0].Quality);
        }
    }
}
