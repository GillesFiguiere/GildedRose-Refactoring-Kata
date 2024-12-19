namespace GildedRoseKata.Items;

public class ElixirOfTheMongoose(int sellIn, int quality) : AbstractItem(sellIn, quality)
{
    public override string Name => "Elixir of the Mongoose";
}