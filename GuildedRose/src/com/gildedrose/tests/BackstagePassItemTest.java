package com.gildedrose.tests;

import com.gildedrose.items.*;
import com.gildedrose.GildedRose;

import org.junit.Test;
import static org.junit.Assert.*;


public class BackstagePassItemTest {

    @Test
    public void updateQuality_SellinEqualsEleven_QualityIncreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 11, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(10, items[0].sellIn);
        assertEquals(21, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsTen_QualityIncreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 10, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(22, items[0].quality);
    }

    @Test
    public void updateQuality_SellinBetweenSixAndTen_QualityIncreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 6, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(5, items[0].sellIn);
        assertEquals(22, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsFive_QualityIncreaseByThree() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 5, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(4, items[0].sellIn);
        assertEquals(23, items[0].quality);
    }

    @Test
    public void updateQuality_SellinBetweenOneAndFive_QualityIncreaseByThree() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 1, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(0, items[0].sellIn);
        assertEquals(23, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsZero_QualityToZero() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 0, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsZero_QualityIncreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 11, 0) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(10, items[0].sellIn);
        assertEquals(1, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsFifty_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 11, 50) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(10, items[0].sellIn);
        assertEquals(50, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsFortyNine_QualityToFifty() {
    	//Arrange
        Item[] items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Backstage passes to a TAFKAL80ETC concert", items[0].name);
        assertEquals(4, items[0].sellIn);
        assertEquals(50, items[0].quality);
    }

}
