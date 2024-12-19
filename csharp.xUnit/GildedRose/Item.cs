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
        this.SellIn--;
    }
}