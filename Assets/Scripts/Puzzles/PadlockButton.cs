using UnityEngine;

public class PadlockButton : MonoBehaviour
{
    [SerializeField] Padlock padlock = null;
    [SerializeField] string digit = "1";
    void OnMouseDown()
    {
        if(padlock)
        {
            padlock.AddDigit(digit);
        }
    }
}
