using UnityEngine;

/*
 * If attached to a game object, forces no more than one child 
 * of said game object to be active at a time.
 * 
 * If more than one child is active, either the newly activated 
 * child or the previously activated child, depending on 
 * designer preference, is immediately deactivated during 
 * the Update callback. 
 * 
 * Useful for preventing multiple UI elements from being active at once.
 */
public class ForceSingleActiveChild : MonoBehaviour
{
    [Tooltip("If two children are active at once, should the newly activated child replace the old one?")]
    [SerializeField] bool replaceActiveChild = false;

    GameObject curActiveChild = null;

    void Update()
    {
        bool activeChildFound = false;

        // Iterates through this game object's children.
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeSelf)
            {
                activeChildFound = true;

                // If the current active child is not set,
                // the new activation is valid and
                // the current active child is updated.
                if (!curActiveChild)
                {
                    curActiveChild = child.gameObject;
                }

                // Otherwise the new activation is not valid
                // and one of the objects must be deactivated.
                else if (curActiveChild != child.gameObject)
                {
                    // The newly activated child replaces the old one.
                    if (replaceActiveChild)
                    {
                        curActiveChild.SetActive(false);
                        curActiveChild = child.gameObject;
                    }
                    // The newly activated child is immediately deactivated.
                    else
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
        }

        // If no active children are found, the current active child is unset.
        if (!activeChildFound)
        {
            curActiveChild = null;
        }
    }
}
