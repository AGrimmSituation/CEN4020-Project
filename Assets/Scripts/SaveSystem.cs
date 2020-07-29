using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

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

	public static void SaveGame()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/savedGame";
		FileStream stream = new FileStream(path, FileMode.Create);

		StateData data = new StateData();

		formatter.Serialize(stream, data);
		stream.Close();
	}

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
