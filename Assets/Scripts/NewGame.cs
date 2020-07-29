using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
	void OnMouseDown()
	{
	SaveSystem.NewGame();
	SceneManager.LoadScene(SavedState.lastScene);
	}
}
