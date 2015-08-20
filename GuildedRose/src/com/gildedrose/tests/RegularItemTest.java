package com.gildedrose.tests;

import com.gildedrose.items.*;
import com.gildedrose.GildedRose;

import org.junit.Test;
import static org.junit.Assert.*;


public class RegularItemTest {

    @Test
    public void updateQuality_SellinGreterThanZero_QualityDecreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("+5 Dexterity Vest", 10, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("+5 Dexterity Vest", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(19, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsZero_QualityDecreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("+5 Dexterity Vest", 0, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("+5 Dexterity Vest", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(18, items[0].quality);
    }

    @Test
    public void updateQuality_SellinLessThanZero_QualityDecreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("+5 Dexterity Vest", -1, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("+5 Dexterity Vest", items[0].name);
        assertEquals(-2, items[0].sellIn);
        assertEquals(18, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("+5 Dexterity Vest", 10, 0) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("+5 Dexterity Vest", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

    @Test
    public void updateQuality_QualityEqualsFifty_QualityDecreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("+5 Dexterity Vest", 10, 50) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("+5 Dexterity Vest", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(49, items[0].quality);
    }

}
