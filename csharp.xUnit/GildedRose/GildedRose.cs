using System.Collections.Generic;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public class GildedRose
{
    IList<AbstractItem> Items;

    public GildedRose(IList<AbstractItem> items)
    {
        Items = items;
    }

    public void Update()
    {
        foreach (var item in Items)
        {
            item.Update();
        }
    }
}