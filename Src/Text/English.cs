﻿namespace OOPAdventure;

public class English : Language
{
	public English()
	{
		ChoseYourName = "Hello, What is Your name?";
		DefaultName = "No name";
		Welcome = "Welcome {0} to your OPP adventure";
		DefaultRoomName = "Room {0} ({1},{2})";
		DefaultRoomDescription = " You are in a {0} the room with doors to the {1}.";
		ActionError= "You can't do that.";
		Go = "Go";
		GoError = "You can't go that way";
		WhatTodO = "What do you want to do?";
		Quit = "quit";
		RoomNew = "You entered {0}.";
		RoomOld = "You return {0}.";
		And = "and";
		Comma = ",";
		Space = " ";
		RoomDescription = new List<string>
		{
			"normal",
            "cold",
            "warm",
            "dark",
            "bright",
            "scary",
            "strange",
        };
		NoItem = "You don't have {0}.";
		Backpack = "Backpack";
		BackpackError = "You don't have anything in your backpack.";
		BackpackDescription = "Your backpack contains {0}.";
		Chest = "chest";
		UnlockChest = "You unlocked the chest.";
		Key = "key";
		ChestEmpty = "The chest is empty";
		ChestFound = "You found {0}";
		Gold = "{0} gold {1}";
		Coin = "coin";
		Coins = Coin + "s";
		Plural = "s";
		Is = "is";
		Are = "are";
		TotalItems = " There {0} {1} item{2} in the room: ";
		Period = ".";
		Take = "Take";
		TakeError = "You can't take that";
		TookDescription = "you took a {0}";
		CantTakeDescription = "You can't take the {0}.";
		Use = "Use";
		UseSuccess = "You used the {0}";
		UseError = "You can't use that.";
    }
}