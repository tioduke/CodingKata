package com.gildedrose.tests;

import com.gildedrose.items.*;
import com.gildedrose.GildedRose;

import org.junit.Test;
import static org.junit.Assert.*;


public class AgedItemTest {

    @Test
    public void updateQuality_SellinGreterThanZero_QualityIncreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("Aged Brie", 10, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Aged Brie", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(21, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsZero_QualityIncreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Aged Brie", 0, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Aged Brie", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(22, items[0].quality);
    }

    @Test
    public void updateQuality_SellinLessThanZero_QualityIncreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Aged Brie", -1, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Aged Brie", items[0].name);
        assertEquals(-2, items[0].sellIn);
        assertEquals(22, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsZero_QualityIncreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("Aged Brie", 10, 0) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Aged Brie", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(1, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsFifty_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Aged Brie", 10, 50) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Aged Brie", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(50, items[0].quality);
    }

}
