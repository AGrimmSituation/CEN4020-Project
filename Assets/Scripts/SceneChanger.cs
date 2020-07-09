using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //Apply to a door object
    //When a door is clicked on, this script will load the 
    //level attached to the door.

    [SerializeField] string sceneName = null;

    void OnMouseDown()
    {
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.Log("Scene \"" + sceneName + "\" has not been added to Build Settings.");
        }
    }
}
