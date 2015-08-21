package com.gildedrose;

import com.gildedrose.items.*;

public class GildedRose {
    Item[] items;

    public GildedRose(Item[] items) {
        this.items = items;
    }

    public void updateQuality() {
        for (int i = 0; i < items.length; i++) {
             ItemDecorator decoratedItem = ItemDecoratorFactory.getInstance(items[i]);
             decoratedItem.update();
        }
    }
}
