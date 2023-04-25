﻿namespace OOPAdventure;

public class Chest : Item, IInventory
{
    private readonly House _house;
    private readonly Inventory _inventor = new();

    public override string Name => Text.Language.Chest;

    public bool Locked => true;

    public Chest(Item?[] items, House house)
    { 
        CanTake = false;

        _house = house;
        foreach (var item in items)
        {
            Add(item);
        }
    }

    public override void Use(string source)
    {
        if (source == Text.Language.Key)
        {
            var items = InventoryList;

            if (Locked)
                Console.WriteLine(Text.Language.UnlockChest);

            if (items.Length == 0)
            {
                Console.WriteLine(Text.Language.ChestEmpty);
            }
            else
            {
                Console.WriteLine(string.Format(Text.Language.ChestFound,Text.Language.JoinedWordList(items, Text.Language.And)));
            }

            foreach(var itemName in items)
            {
                var item = Take(itemName);
                _house.Player.Add(item);
            }
        }
    }

    public int Total => ((IInventory)_inventor).Total;

    public string[] InventoryList => ((IInventory)_inventor).InventoryList;

    public void Add(Item item)
    {
        ((IInventory)_inventor).Add(item);
    }

    public bool Contains(string itemName)
    {
        return ((IInventory)_inventor).Contains(itemName);
    }

    public Item? Find(string itemName)
    {
        return ((IInventory)_inventor).Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return ((IInventory)_inventor).Find(itemName, remove);
    }

    public void Remove(Item item)
    {
        ((IInventory)_inventor).Remove(item);
    }

    public Item? Take(string itemName)
    {
        return ((IInventory)_inventor).Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        ((IInventory)_inventor).Use(itemName, source);
    }
}

