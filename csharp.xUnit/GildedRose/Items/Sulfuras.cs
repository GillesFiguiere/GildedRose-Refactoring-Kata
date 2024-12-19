namespace GildedRoseKata.Items;

public class Sulfuras(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "Sulfuras, Hand of Ragnaros";

    public override void Update()
    {
        // Sulfuras never change
    }
}