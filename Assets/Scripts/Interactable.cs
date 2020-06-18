using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] GameObject UItoShow = null;

    void OnMouseDown()
    {
        if (UItoShow && interacting == false)
        {
            UItoShow.SetActive(true);
            interacting = true;
        }
    }

    public static bool interacting = false;

}