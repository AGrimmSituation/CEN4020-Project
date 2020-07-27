using UnityEngine;

public class OpenGameMenu : MonoBehaviour
{
    //Attaches a UI to this function call.
    [SerializeField] GameObject UItoShow = null;
    // Update is called once per frame. It will check to see if the menu button is called. We use escape as it is the most common menu button in similar applications
    void Update()
    {
        if(Input.GetKey("escape"))  //If the player presses escape key, attempt to open menu.
        {
            if (UItoShow)           //If there is no menu to open, nothing will happen.
                UItoShow.SetActive(true);
        }
    }
}
