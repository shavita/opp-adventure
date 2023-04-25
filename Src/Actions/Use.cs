namespace OOPAdventure;

public class Use : IAction
{
	private readonly House _house;
	public Use(House house)
	{
		_house= house;
	}

    public string Name => Text.Language.Use;

    public void Execute(string[] args)
    {
        if (args.Length <1)
        {
            Console.WriteLine(Text.Language.UseError);
            return;
        }

        var itemName = args[1];
        if (_house.Player.Contains(itemName)) 
        {
            var item = _house.Player.Take(itemName);

            Console.Write(Text.Language.UseSuccess, item.Name);

            item.Use(itemName);

        }
        else
        {
            Console.WriteLine(Text.Language.UseError);
        }

    }
}
