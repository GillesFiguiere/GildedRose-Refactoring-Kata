namespace GildedRoseKata.Items;

public class AgedBrie(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "Aged Brie";

    public override void Update()
    {
        DecreaseSellIn();

        if (IsNotExpired())
        {
            IncreaseQualityBy(1);
        }
        else
        {
            IncreaseQualityBy(2);
        }
    }
}