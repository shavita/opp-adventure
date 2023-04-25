namespace OOPAdventure;

public class Go : OOPAdventure.IAction
{
    public string Name => Text.Language.Go;

    private readonly House _house;

    public Go(House house)
    {
        _house = house;
    }

    public void Execute(string[] args)
    {
        var currenRoom = _house.CurrentRoom;

        var dir = args[1].Substring(0,1).ToUpper() + args[1].Substring(1).ToLower();

        Enum.TryParse(dir, out Directions newDirections);

        var nextroomIndex = currenRoom.Neighbors[newDirections];

        if (nextroomIndex == -1 || newDirections == Directions.None)
            Console.WriteLine(Text.Language.GoError);
        else
            _house.GotoRoom(nextroomIndex);
    }

}