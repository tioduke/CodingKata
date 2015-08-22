package com.gildedrose.tests;

import com.gildedrose.items.*;
import com.gildedrose.GildedRose;

import org.junit.Test;
import static org.junit.Assert.*;


public class ConjuredItemTest {

    @Test
    public void updateQuality_SellinGreterThanZero_QualityDecreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Conjured Mana Cake", 10, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Conjured Mana Cake", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(18, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsZero_QualityDecreaseByFour() {
    	//Arrange
        Item[] items = new Item[] { new Item("Conjured Mana Cake", 0, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Conjured Mana Cake", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(16, items[0].quality);
    }

    @Test
    public void updateQuality_SellinLessThanZero_QualityDecreaseByFour() {
    	//Arrange
        Item[] items = new Item[] { new Item("Conjured Mana Cake", -1, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Conjured Mana Cake", items[0].name);
        assertEquals(-2, items[0].sellIn);
        assertEquals(16, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Conjured Mana Cake", 10, 0) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Conjured Mana Cake", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsFifty_QualityDecreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Conjured Mana Cake", 10, 50) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Conjured Mana Cake", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(48, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsThree_QualityToZero() {
    	//Arrange
        Item[] items = new Item[] { new Item("Conjured Mana Cake", 0, 3) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Conjured Mana Cake", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

}
