using System;
using System.Collections.Generic;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<AbstractItem> items = new List<AbstractItem>
        {
            new DexterityVest(sellIn: 10, quality: 20),
            new AgedBrie(sellIn: 2, quality: 0),
            new ElixirOfTheMongoose(sellIn: 5, quality: 7),
            new Sulfuras(sellIn: 0, quality: 80),
            new Sulfuras(sellIn: -1, quality: 80),
            new BackstagePasses(sellIn: 15, quality: 20),
            new BackstagePasses(sellIn: 10, quality: 49),
            new BackstagePasses(sellIn: 5, quality: 49),
            // this conjured item does not work properly yet
            new ConjuredManaCake(sellIn: 3, quality: 6)
        };

        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.Update();
        }
    }
}