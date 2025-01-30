namespace GildedRoseKata.Items;

public class AgedBrie(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "Aged Brie";

    protected override void UpdateQuality()
    {
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