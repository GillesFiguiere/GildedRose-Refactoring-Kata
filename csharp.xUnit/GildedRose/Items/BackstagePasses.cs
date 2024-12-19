namespace GildedRoseKata.Items;

public class BackstagePasses(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "Backstage passes to a TAFKAL80ETC concert";

    public override void Update()
    {
        DecreaseSellIn();

        if (IsNotExpired())
        {
            if (WillExpireIn(5))
            {
                IncreaseQualityBy(3);
            }
            else if (WillExpireIn(10))
            {
                IncreaseQualityBy(2);
            }
            else
            {
                IncreaseQualityBy(1);
            }
        }
        else
        {
            SetQualityToLowest();
        }
    }
}