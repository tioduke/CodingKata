package com.gildedrose.tests;

import com.gildedrose.items.*;
import com.gildedrose.GildedRose;

import org.junit.Test;
import static org.junit.Assert.*;


public class SuspiciousItemTest {

    @Test
    public void updateQuality_SellinEvenAndGreterThanZero_QualityDecreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 10, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(18, items[0].quality);
    }

    @Test
    public void updateQuality_SellinOddAndGreterThanZero_QualityDecreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 9, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(8, items[0].sellIn);
        assertEquals(19, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsZero_QualityDecreaseByFour() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 0, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(16, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEvenAndLessThanZero_QualityDecreaseByFour() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", -2, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(-3, items[0].sellIn);
        assertEquals(16, items[0].quality);
    }

    @Test
    public void updateQuality_SellinOddAndLessThanZero_QualityDecreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", -1, 20) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(-2, items[0].sellIn);
        assertEquals(18, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEvenAndQualityEqualsZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 10, 0) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

    @Test
    public void updateQuality_SellinOddAndQualityEqualsZero_QualityUnchanged() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 9, 0) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(8, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEvenAndQualityEqualsFifty_QualityDecreaseByTwo() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 10, 50) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(9, items[0].sellIn);
        assertEquals(48, items[0].quality);
    }

    @Test
    public void updateQuality_SellinOddAndQualityEqualsFifty_QualityDecreaseByOne() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 9, 50) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(8, items[0].sellIn);
        assertEquals(49, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsZeroAndQualityEqualsThree_QualityToZero() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", 0, 3) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(-1, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

    @Test
    public void updateQuality_SellinEqualsNegativeOneAndQualityEqualsOne_QualityToZero() {
    	//Arrange
        Item[] items = new Item[] { new Item("Suspicious Wooden shield", -1, 1) };
        GildedRose app = new GildedRose(items);
        
        //Act
        app.updateQuality();
        
        //Assert
        assertEquals("Suspicious Wooden shield", items[0].name);
        assertEquals(-2, items[0].sellIn);
        assertEquals(0, items[0].quality);
    }

}
