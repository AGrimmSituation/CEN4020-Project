using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceSingleActiveChild : MonoBehaviour
{
    [Tooltip("If two children are active at once, should the newly enabled child replace the old one?")]
    [SerializeField] bool replaceActiveChild = false;

    public GameObject curActiveChild = null;

    void Update()
    {
        bool activeChildFound = false;

        foreach (Transform child in transform)
        {
            if (child.gameObject.activeSelf)
            {
                activeChildFound = true;

                if (!curActiveChild)
                {
                    curActiveChild = child.gameObject;
                }

                if (curActiveChild != child.gameObject)
                {
                    if (replaceActiveChild)
                    {
                        curActiveChild.SetActive(false);
                        curActiveChild = child.gameObject;
                    }
                    else
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
        }

        if (!activeChildFound)
        {
            curActiveChild = null;
        }
    }
}
