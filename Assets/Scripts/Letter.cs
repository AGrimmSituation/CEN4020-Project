using UnityEngine;


public class Letter : MonoBehaviour
{
    [SerializeField]GameObject letterUI;
    void OnMouseDown()
    {
        letterUI.SetActive(true);
    }
}
