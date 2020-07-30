//Erase the save data and load into the first room.

using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
	void OnMouseDown()
	{
		SaveSystem.NewGame();							//Resets all rooms
		SceneManager.LoadScene(SavedState.lastScene);	//Begin game in first room.
	}
}
