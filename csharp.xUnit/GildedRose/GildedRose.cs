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
            // TODO strings en dur répétées => attention les TYPOS
            if (item.Name == "Aged Brie")
            {
                item.DecreaseSellIn();

                if (item.IsNotExpired())
                {
                    item.IncreaseQualityBy(1);
                }
                else
                {
                    item.IncreaseQualityBy(2);
                }
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                item.DecreaseSellIn();

                if (item.IsNotExpired())
                {
                    if (item.WillExpireIn(5))
                    {
                        item.IncreaseQualityBy(3);
                    }
                    else if (item.WillExpireIn(10))
                    {
                        item.IncreaseQualityBy(2);
                    }
                    else
                    {
                        item.IncreaseQualityBy(1);
                    }
                }
                else
                {
                    item.SetQualityToLowest();
                }
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                // Sulfuras ne change jamais
            }
            else
            {
                item.DecreaseSellIn();


                if (item.IsNotExpired())
                {
                    item.DecreaseQualityBy(1);
                }
                else
                {
                    item.DecreaseQualityBy(2);
                }
            }
        }
    }
}