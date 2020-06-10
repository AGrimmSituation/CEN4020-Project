using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]GameObject UItoShow = null;
    void OnMouseDown()
    {
        if (UItoShow)
        {
            UItoShow.SetActive(true);
        }
    }
}