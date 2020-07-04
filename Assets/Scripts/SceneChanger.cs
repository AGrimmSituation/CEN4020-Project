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
        SceneManager.LoadScene(sceneName);
    }
}
