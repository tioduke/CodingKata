package com.gildedrose.tests;

import com.gildedrose.items.*;
import com.gildedrose.GildedRose;

import org.junit.Test;
import static org.junit.Assert.*;


public class LegendaryItemTest {

    @Test
    public void updateQuality_SellinGreterThanZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Sulfuras, Hand of Ragnaros", 10, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Sulfuras, Hand of Ragnaros", items[0].name);
        assertEquals(10, items[0].sellIn);
        assertEquals(20, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Sulfuras, Hand of Ragnaros", 0, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Sulfuras, Hand of Ragnaros", items[0].name);
        assertEquals(0, items[0].sellIn);
        assertEquals(20, items[0].quality);
    }

    @Test
    public void updateQuality_SellinLessThanZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Sulfuras, Hand of Ragnaros", -1, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Sulfuras, Hand of Ragnaros", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(20, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Sulfuras, Hand of Ragnaros", 10, 0) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Sulfuras, Hand of Ragnaros", items[0].name);
        assertEquals(10, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsFifty_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Sulfuras, Hand of Ragnaros", 10, 50) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Sulfuras, Hand of Ragnaros", items[0].name);
        assertEquals(10, items[0].sellIn);
        assertEquals(50, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsEighty_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Sulfuras, Hand of Ragnaros", 10, 80) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Sulfuras, Hand of Ragnaros", items[0].name);
        assertEquals(10, items[0].sellIn);
        assertEquals(80, items[0].quality);
    }

}
