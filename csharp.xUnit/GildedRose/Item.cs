namespace GildedRoseKata;

public class Item
{
    private const int MinQuality = 0;
    private const int MaxQuality = 50;
    
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
        DecreaseQualityBy(1);
    }

    public void IncreaseQuality()
    {
        IncreaseQualityBy(1);
    }

    public void IncreaseQualityBy(int increment)
    {
        if (Quality + increment <= MaxQuality)
        {
            Quality += increment;
        }
        else
        {
            Quality = MaxQuality;
        }
    }

    public void DecreaseQualityBy(int decrement)
    {
        if (Quality - decrement >= MinQuality)
        {
            Quality -= decrement;
        }
        else
        {
            Quality = MinQuality;
        }
    }

    public void SetQualityToLowest()
    {
        Quality = 0;
    }

    public bool IsExpired() => SellIn < 0;

    public bool IsNotExpired() => !IsExpired();

    public bool WillExpireIn(int days) => SellIn < days;

    public void DecreaseSellIn()
    {
        SellIn--;
    }
}