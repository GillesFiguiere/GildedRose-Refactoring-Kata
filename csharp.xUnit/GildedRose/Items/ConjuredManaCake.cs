namespace GildedRoseKata.Items;

public class ConjuredManaCake(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "Conjured Mana Cake";
}