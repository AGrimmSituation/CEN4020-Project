using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] GameObject UItoShow = null;

    //when clicking on the sprite, it should open up
    //the UI attached to it if it exists.
    //if not, nothing will happen
    void OnMouseDown()
    {
        if (UItoShow && PauseMenu.paused == false)
        {
            UItoShow.SetActive(true);
        }
    }
}
