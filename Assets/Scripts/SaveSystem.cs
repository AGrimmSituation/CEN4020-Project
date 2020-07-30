using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
	//Erase all saved data by setting all puzzles to unsolved and locking doors.
	//Set the current scene to be the living room
	public static void NewGame()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/savedGame";
		FileStream stream = new FileStream(path, FileMode.Create);

		SavedState.livingRoomPadlockSolved = false;
		SavedState.clockSolved = false;
		SavedState.fridgeSolved = false;
		SavedState.tvSolved = false;
		SavedState.bedroomPadlockSolved = false;
		SavedState.lastScene = "Living Room";

		StateData data = new StateData();

		formatter.Serialize(stream, data);
		stream.Close();
	}

	//Save all progress on puzzles, unlocked doors, and most recently visited room.
	public static void SaveGame()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/savedGame";
		FileStream stream = new FileStream(path, FileMode.Create);

		StateData data = new StateData();

		formatter.Serialize(stream, data);
		stream.Close();
	}

	//Reload the game from the most recent call of SaveGame().
	public static void LoadGame()
	{
		string path = Application.persistentDataPath + "/savedGame";
		if(File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);

			StateData data = formatter.Deserialize(stream) as StateData;
			stream.Close();

			SavedState.livingRoomPadlockSolved = data.lrPadlock;
			SavedState.clockSolved = data.clock;
			SavedState.fridgeSolved = data.fridge;
			SavedState.tvSolved = data.tv;
			SavedState.bedroomPadlockSolved = data.brPadlock;
			SavedState.lastScene = data.lastScene;

			return;

		}
		else
		{
			Debug.LogError("File not found!");
			return;
		}



	}



}
