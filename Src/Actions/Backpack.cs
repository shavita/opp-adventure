namespace OOPAdventure;

public class Backpack : IAction
{
    private readonly IInventory _inventory;

	public Backpack(IInventory inventory)
	{
		_inventory= inventory;
	}

	public string Name => Text.Language.Backpack;

    public void Execute(string[] args)
    {
        var items = _inventory.InventoryList;
        if (items.Length == 0)
        {
            Console.WriteLine(Text.Language.BackpackError); 
            return;
        }

        var list = Text.Language.JoinedWordList(items, Text.Language.And);

        Console.WriteLine(Text.Language.BackpackDescription, list);
    }
}