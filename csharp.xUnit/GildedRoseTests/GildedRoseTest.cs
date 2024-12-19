using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Items;

namespace GildedRoseTests;

public class GildedRoseTest
{
    public static TheoryData<AbstractItem, int, int> CasDeTest => new()
    {
        { new DexterityVest(5, 3), 4, 2 },
        { new AgedBrie(5, 3), 4, 4 },
        { new BackstagePasses(5, 3), 4, 6 },
        { new BackstagePasses(8, 3), 7, 5 },
        { new BackstagePasses(13, 3), 12, 4 },
        { new BackstagePasses(-1, 3), -2, 0 },
        { new DexterityVest(-1, 3), -2, 1 },
        { new AgedBrie(-1, 3), -2, 5 },
    };

    [Theory]
    [MemberData(nameof(CasDeTest))]
    public void ShouldUpdateQualityForDexterityVest(AbstractItem abstractItem, int sellInExpected, int qualityExpected)
    {
        List<AbstractItem> items = [abstractItem];
        GildedRose app = new(items);
        
        app.Update();
        
        Assert.Equal(abstractItem.Name, items[0].Name);
        Assert.Equal(sellInExpected, items[0].SellIn);
        Assert.Equal(qualityExpected, items[0].Quality);
    }
}