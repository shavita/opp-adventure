namespace OOPAdventure;

public partial class House
{
    public Player Player { get; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Room[] Rooms { get; private set; }

    private readonly Random _rnd = new(1234);


    public House(Player player)
    {
        Player = player;        
    }
}