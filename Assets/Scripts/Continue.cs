//Enter the game using progress from a recently saved session.

using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
	void OnMouseDown()
	{
		SaveSystem.LoadGame();							//Restore solved puzzles and unlocked rooms
		SceneManager.LoadScene(SavedState.lastScene);	//Enter the room from which the player last left off.
	}
}
