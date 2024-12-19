namespace GildedRoseKata;

public class Item
{
    public string Name { get; }
    public int SellIn { get; private set; }
    public int Quality { get; private set; }

    public Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public void DecreaseQuality()
    {
        if (Quality > 0)
        {
            Quality--;
        }
    }

    public void IncreaseQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }

    public void SetQualityToLowest()
    {
        Quality = 0;
    }

    public bool IsExpired() => SellIn < 0;

    public bool WillExpireIn(int days) => SellIn < days;

    public void DecreaseSellIn()
    {
        SellIn--;
    }
}