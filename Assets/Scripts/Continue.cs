using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
	void OnMouseDown()
	{
		SaveSystem.LoadGame();
		SceneManager.LoadScene(SavedState.lastScene);
	}
}
