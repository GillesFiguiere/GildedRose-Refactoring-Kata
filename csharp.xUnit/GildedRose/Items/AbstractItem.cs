﻿namespace GildedRoseKata.Items;

public abstract class AbstractItem(int sellIn, int quality)
{
    private const int MinQuality = 0;
    private const int MaxQuality = 50;

    public abstract string Name { get; }

    public int SellIn { get; private set; } = sellIn;

    public int Quality { get; private set; } = quality;

    public void Update()
    {
        DecreaseSellIn();

        UpdateQuality();
    }

    protected virtual void UpdateQuality()
    {
        if (IsNotExpired())
        {
            DecreaseQualityBy(1);
        }
        else
        {
            DecreaseQualityBy(2);
        }
    }

    protected void IncreaseQualityBy(int increment)
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

    protected void DecreaseQualityBy(int decrement)
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

    protected void SetQualityToLowest()
    {
        Quality = MinQuality;
    }

    protected bool IsExpired() => SellIn < 0;

    protected bool IsNotExpired() => !IsExpired();

    protected bool WillExpireIn(int days) => SellIn < days;

    protected virtual void DecreaseSellIn()
    {
        SellIn--;
    }
}