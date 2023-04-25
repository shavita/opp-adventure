namespace OOPAdventure;

public partial class House
{
    public Room CurrentRoom { get; set; }
    public void GotoRoom(int index)
    { 
        if (CurrentRoom != null)
            CurrentRoom.Visited= true;

        CurrentRoom = Rooms[index];
    }

    public void GoToStartRoom()
    { 
        GotoRoom( _rnd.Next(0,Rooms.Length) );
    }
}