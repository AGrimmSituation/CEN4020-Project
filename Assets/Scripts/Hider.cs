using UnityEngine;

public class Hider : MonoBehaviour
{
    [SerializeField] GameObject objectToHide = null;

    void OnMouseDown()
    {
        if (objectToHide)
        {
            objectToHide.SetActive(false);
        }
    }
}

