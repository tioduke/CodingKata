using Xunit;
using Xunit.Categories;

using GildedRose.Net.Items;

namespace GildedRose.Net.Tests.Items
{
    public class SuspicicousItemTest
    {
        [Fact, UnitTest]
        public void UpdateQuality_SellinEvenAndGreterThanZero_QualityDecreaseByTwo()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinOddAndGreterThanZero_QualityDecreaseByOne()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsZero_QualityDecreaseByFour()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinEvenAndLessThanZero_QualityDecreaseByFour()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinOddAndLessThanZero_QualityDecreaseByTwo()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinEvenAndQualityEqualsZero_QualityUnchanged()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinOddAndQualityEqualsZero_QualityUnchanged()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinEvenAndQualityEqualsFifty_QualityDecreaseByTwo()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinOddAndQualityEqualsFifty_QualityDecreaseByOne()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsZeroAndQualityEqualsThree_QualityToZero()
        {
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

        [Fact, UnitTest]
        public void UpdateQuality_SellinEqualsNegativeOneAndQualityEqualsOne_QualityToZero()
        {
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
