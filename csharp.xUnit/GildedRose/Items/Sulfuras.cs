namespace GildedRoseKata.Items;

public class Sulfuras(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "Sulfuras, Hand of Ragnaros";

    protected override void UpdateQuality()
    {
        // Sulfuras never change
    }

    protected override void DecreaseSellIn()
    {
        // Sulfuras never change
    }
}