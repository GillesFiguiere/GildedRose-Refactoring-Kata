namespace GildedRoseKata.Items;

public class DexterityVest(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "+5 Dexterity Vest";
}