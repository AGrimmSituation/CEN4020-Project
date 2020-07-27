//When clicking "Quit" option in menu, this script will close the program.

using System.Collections;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    [SerializeField] GameObject MenuItem = null;
    //Click "Quit" to trigger Quit function.
    void OnMouseDown()
    {
        if (MenuItem)
            Application.Quit();
    }
}
