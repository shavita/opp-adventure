using System.Runtime.CompilerServices;

namespace OOPAdventure;

public class Take : IAction
{
	private readonly House _house;
	public Take(House house)
	{
		_house= house;

	}
    public string Name => Text.Language.Take;
    public void Execute(string[] args)
    {
        if (args.Length == 1)
        {
            Console.WriteLine(Text.Language.NotTaken);
            return;
        }

        var inventory = _house.CurrentRoom;
        var itemName = args[1].ToLower();

        if (inventory.Contains(itemName))
        { 
            var item = inventory.Take(itemName);

            if (item.CanTake)
            {
                _house.Player.Add(item);
                Console.WriteLine(Text.Language.TookDescription, item.Name);
            }
            else
            {
                Console.WriteLine(Text.Language.CantTakeDescription, item.Name);
            }
            return;
        }
        Console.WriteLine(Text.Language.TakeError);
    }

}