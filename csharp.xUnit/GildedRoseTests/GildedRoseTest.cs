using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Theory]
    [InlineData("+5 Dexterity Vest", 5, 3, 4, 2 )]
    [InlineData("Aged Brie", 5, 3, 4, 4 )]
    [InlineData("Backstage passes to a TAFKAL80ETC concert", 5, 3, 4, 6 )]
    [InlineData("Backstage passes to a TAFKAL80ETC concert", 8, 3, 7, 5 )]
    [InlineData("Backstage passes to a TAFKAL80ETC concert", 13, 3, 12, 4 )]
    [InlineData("Backstage passes to a TAFKAL80ETC concert", -1, 3, -2, 0 )]
    [InlineData("+5 Dexterity Vest", -1, 3, -2, 1 )]
    [InlineData("Aged Brie", -1, 3, -2, 5 )]
    public void ShouldUpdateQualityForDexterityVest(string name, int sellInBefore, int qualityBefore, int sellInExpected, int qualityExpected)
    {
        IList<Item> items = new List<Item> { new Item { Name = name, SellIn = sellInBefore, Quality =qualityBefore} };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal(name, items[0].Name);
        Assert.Equal(sellInExpected, items[0].SellIn);
        Assert.Equal(qualityExpected, items[0].Quality);
    }
}