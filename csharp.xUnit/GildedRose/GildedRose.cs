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
        // TODO On ne voit pas les règles métiers 
        // exemple si c'es agedbrie je fais ça, si c'est Sulfuras, etc.
        foreach (var item in Items)
        {
            // TODO strings en dur répétées => attention les TYPOS
            if (item.Name == "Aged Brie" || item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality < 50)
                {
                    // Duplication incrémentation
                    item.Quality = item.Quality + 1;

                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        // Duplication quality < 50
                        if (item.SellIn < 11 && item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }

                        if (item.SellIn < 6 && item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
            else
            {
                // Duplication quality > 0
                if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    // Duplication décrémentation
                    item.Quality = item.Quality - 1;
                }
            }

            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
            }
            else
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name == "Aged Brie")
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
                else
                {
                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        item.Quality = 0;
                    }
                    else
                    {
                        if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
            }
        }
    }
}