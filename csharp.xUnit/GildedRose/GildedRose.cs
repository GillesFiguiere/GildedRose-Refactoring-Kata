using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.DecreaseSellIn();
            }

            // TODO strings en dur répétées => attention les TYPOS
            if (item.Name == "Aged Brie")
            {
                item.IncreaseQuality();

                if (item.IsExpired())
                {
                    item.IncreaseQuality();
                }
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.IsExpired())
                {
                    item.SetQualityToLowest();
                }
                else
                {
                    item.IncreaseQuality();

                    if (item.WillExpireIn(10))
                    {
                        item.IncreaseQuality();
                    }

                    if (item.WillExpireIn(5))
                    {
                        item.IncreaseQuality();
                    }
                }
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                // Sulfuras ne change jamais
            }
            else
            {
                item.DecreaseQuality();

                if (item.IsExpired())
                {
                    item.DecreaseQuality();
                }
            }
        }
    }
}