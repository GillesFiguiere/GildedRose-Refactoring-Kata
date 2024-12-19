namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void DecreaseQuality()
    {
        if (Quality > 0)
        {
            Quality -= 1;
        }
    }

    public void IncreaseQuality()
    {
        if (this.Quality < 50)
        {
            this.Quality = this.Quality + 1;
        }
    }
}