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
                item.SellIn--;
            }

            // TODO strings en dur répétées => attention les TYPOS
            if (item.Name == "Aged Brie")
            {
                item.IncreaseQuality();
                if (item.SellIn < 0)
                {
                    item.IncreaseQuality();
                }
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                }

                else
                {
                    item.IncreaseQuality();


                    if (item.SellIn < 10)
                    {
                        item.IncreaseQuality();
                    }

                    if (item.SellIn < 5)
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

                if (item.SellIn < 0)
                {
                    item.DecreaseQuality();
                }
            }
        }
    }
}