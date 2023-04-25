namespace OOPAdventure;


public partial class House
{
    public void DecorateRooms() 
    {
        foreach (var room in Rooms)
        {
            var roomDescription = Text.Language.RoomDescription[0];

            if (Text.Language.RoomDescription.Count > 1 && _rnd.Next(0,2) ==1) 
            {
                roomDescription = Text.Language.RoomDescription[_rnd.Next(1, Text.Language.RoomDescription.Count)];

                Text.Language.RoomDescription.Remove(roomDescription);
            }

            room.Description = string.Format(Text.Language.DefaultRoomDescription, roomDescription, "{0}");
        }    
    }

    public void PopulateRooms(List<Item> items)
    {
        var i = 0;

        while (i < items.Count)
        {
            var room = Rooms[_rnd.Next(0,Rooms.Length)];

            if (room.Total == 0)
            {
                room.Add(items[i]);
                i++;
            }
        }

    }
}


